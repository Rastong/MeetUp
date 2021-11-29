import { Component, Input, Output, EventEmitter } from '@angular/core';
import { EventService } from '../event.service';
import { EventList } from '../EventList';
import { FavoritesService } from '../favorites.service';
import { ModalService } from '../_modal';


@Component({
  selector: 'app-eventdetail',
  templateUrl: './eventdetail.component.html',
  styleUrls: ['./eventdetail.component.css']
})
/** event detail component*/
export class EventDetailComponent {

  @Input() IsFavePage: boolean = false;
  @Input() Event: EventList = {} as EventList;
  @Output() UpdateFave = new EventEmitter<EventList>();
  display: boolean = false;

  status: string = "";

  
  /** event detail ctor */
  constructor(private service: EventService, private faveService: FavoritesService, private modalService: ModalService) {

  }

  toggleDisplay(): void {
    this.display = !this.display;
  }

  ngOnInit(): void {
    this.status = '';
  }

  openModal(id: string) {
    this.modalService.open(id);
  }

  closeModal(id: string) {
    this.modalService.close(id);
  }

  addToFave(): any {
    this.status = "Added To Favorites";
    this.faveService.addFavorite(this.Event.id, this.Event.categoryID).subscribe((response: any) => {
      console.log(response);
     
    });
  }

  removeFromFave(): any {
    this.status = "Removed from Favorites";
    this.UpdateFave.emit(this.Event);
    this.faveService.deleteFavorite(this.Event.id).subscribe((response: any) => {
      console.log(response);
      
    });
  }

  getCategory(): string {
    let result: string = "";
    if (this.Event.categoryID == 1) {
      result = "Cultures & Languages";
    }
    else if (this.Event.categoryID == 2) {
      result = "Social";
    }
    else if (this.Event.categoryID == 3) {
      result = "Business";
    }
    else if (this.Event.categoryID == 4) {
      result = "Religion";
    }
    else if (this.Event.categoryID == 5) {
      result = "Science";
    }
    else if (this.Event.categoryID == 6) {
      result = "Health & Support";
    }
    else if (this.Event.categoryID == 7) {
      result = "Concert & Performances";
    }

    return result;
  }


}


