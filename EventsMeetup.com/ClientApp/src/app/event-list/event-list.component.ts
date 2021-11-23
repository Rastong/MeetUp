import { Component } from '@angular/core';
import { EventService } from '../event.service';
import { EventList } from '../EventList';

@Component({
    selector: 'app-event-list',
    templateUrl: './event-list.component.html',
    styleUrls: ['./event-list.component.css']
})
/** EventList component*/
export class EventListComponent {
  /** EventList ctor */
    eventList: EventList[] = [];

    constructor(private service: EventService) {

  }


  getMoreInfo(id: number) {
    this.service.getEventById(id)
  }

  ngOnInit(): void {
    this.service.getAllEvents().subscribe((response: any) => {
      this.eventList = response;
      console.log(this.eventList);
    });
  }
}
