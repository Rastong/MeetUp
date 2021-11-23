import { Inject, Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { EventList } from './EventList';
import { NgForm } from '@angular/forms';

@Injectable({
  providedIn: 'root'
})
export class EventService {
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
  postEvent(event: EventList) {
    return this.http.post(this.baseUrl + 'api/Events/AddEvent', event);
  }
 
  
}
