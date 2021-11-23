import { HttpClient } from '@angular/common/http';
import { Inject, Injectable } from '@angular/core';
import { EventList } from './EventList';

@Injectable({
  providedIn: 'root'
})
export class FavoritesService {
  constructor(private http: HttpClient, @Inject('BASE_URL') private baseUrl: string) {

  }



  //GetFavorites
  getFavorites(): any {
    return this.http.get(this.baseUrl + 'api/UserFavorites/GetFavorites');
  }

  //AddFavorite
  //possible issue with route?param="". check on later. 
  addFavorite(eventId: number, categoryId: number): any {
    return this.http.post(this.baseUrl + `api/UserFavorites/AddFavorite?eventId=${eventId}&categoryID=${categoryId}`, eventId);
  }

  deleteFavorite(eventId: number): any {
    return this.http.delete(this.baseUrl + `api/UserFavorites/DeleteFavorite/${eventId}`);
  }

}
