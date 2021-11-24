import { Component, Input, Output, EventEmitter } from '@angular/core';
import { EventService } from '../event.service';
import { EventList } from '../EventList';
import { FavoritesService } from '../favorites.service';

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
  constructor(private service: EventService, private faveService: FavoritesService) {

  }

  toggleDisplay(): void {
    this.display = !this.display;
  }

  ngOnInit(): void {

  }

  addToFave(): any {
    this.faveService.addFavorite(this.Event.id, this.Event.categoryID).subscribe((response: any) => {
      console.log(response);
      this.status = "Added To Favorites";
    });
  }

  removeFromFave(): any {
    this.UpdateFave.emit(this.Event);
    this.faveService.deleteFavorite(this.Event.id).subscribe((response: any) => {
      console.log(response);
      this.status = "Removed from Favorites"
    });
  }


}
