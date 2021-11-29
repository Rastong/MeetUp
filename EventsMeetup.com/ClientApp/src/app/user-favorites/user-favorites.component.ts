import { Component } from '@angular/core';
import { EventService } from '../event.service';
import { EventList } from '../EventList';
import { FavoritesService } from '../favorites.service';


@Component({
    selector: 'app-user-favorites',
    templateUrl: './user-favorites.component.html',
    styleUrls: ['./user-favorites.component.css']
})
/** UserFavorites component*/
export class UserFavoritesComponent {
    /** UserFavorites ctor */
    constructor(private service: FavoritesService, private eventService: EventService){

  }

  simFavorites: EventList[] = [];
  favorites: EventList[] = [];

  ngOnInit(): void {
    this.service.getFavorites().subscribe((response: any) => {
      let faveEvent: any = response;
      console.log(response);
      faveEvent.forEach((E: any) => {
        //subscribes each and every event in the database table "eventLists." Then pushes it to our empty favorites array.
        this.eventService.getEventById(E.eventID).subscribe((eventResponse: EventList) => {
          this.favorites.push(eventResponse);
        })
      });
      //let simEvent: any = response;
      //simEvent.forEach((S: any) => {
      //  this.service.getSimilar(this.favorites).subscribe((res: EventList) => {
      //    this.simFavorites.push(res);
      //  })
      //});
    })
  }

  //to delete the correct event, we find the index of argument. 
  removeFavorite(event: EventList): void {
    let index: number = this.favorites.indexOf(event);
    this.favorites.splice(index, 1);
  }



}
