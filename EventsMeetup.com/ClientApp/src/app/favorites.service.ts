import { HttpClient } from '@angular/common/http';
import { Inject, Injectable } from '@angular/core';
import { EventList } from './EventList';

@Injectable({
  providedIn: 'root'
})
export class FavoritesService {
  constructor(private http: HttpClient, @Inject('BASE_URL') private baseUrl: string) {

  }

  getFavorites(): any {
    return this.http.get(this.baseUrl + 'api/UserFavorites/GetFavorites');
  }

  //maybe use later??!??
  //getSimilar(currentFavs: EventList[]): any {
  //  return this.http.get(this.baseUrl + 'api/UserFavorites/GetSimilar');
  //}
 
  //we need both eventId and categoryId to be sent through because that is what the controller takes as parameters. Backend takes care of the user. 
  addFavorite(eventId: number, categoryId: number): any {
    return this.http.post(this.baseUrl + `api/UserFavorites/AddFavorite?eventId=${eventId}&categoryID=${categoryId}`, eventId);
  }
  //only event id is needed because it is PK.
  deleteFavorite(eventId: number): any {
    return this.http.delete(this.baseUrl + `api/UserFavorites/DeleteFavorite/${eventId}`);
  }


}
