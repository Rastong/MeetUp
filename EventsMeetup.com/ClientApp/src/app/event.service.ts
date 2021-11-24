import { Host, Inject, Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { EventList } from './EventList';
import { NgForm } from '@angular/forms';

@Injectable({
  providedIn: 'root'
})
export class EventService {
  formData: EventList;
  constructor(private http: HttpClient, @Inject('BASE_URL') private baseUrl: string) {

  }

  //getAllEvents
  getAllEvents():any {
    return this.http.get(this.baseUrl + 'api/Events');
  }

  //getEventById
  getEventById(id: number ):any {
    return this.http.get(this.baseUrl + `api/Events/${id}`);
  }

  //addEvent
  postEvent(formData: EventList) {
    return this.http.post(this.baseUrl + `api/Events/AddEvent?name=${formData.name}&host=${formData.host}&categoryID=${formData.categoryID}&summary=${formData.summary}&photo=${formData.photo}&guestCount=${formData.guestCount}&dateAndTime=${formData.dateAndTime}&spotsFilled=${formData.spotsFilled}`, {});
  }
 
  
}
