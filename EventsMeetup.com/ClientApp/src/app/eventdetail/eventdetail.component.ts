import { Component, Input } from '@angular/core';
import { EventService } from '../event.service';
import { EventList } from '../EventList';

@Component({
    selector: 'app-eventdetail',
    templateUrl: './eventdetail.component.html',
    styleUrls: ['./eventdetail.component.css']
})
/** event detail component*/
export class EventDetailComponent {

  @Input() Event: EventList = {} as EventList;
  
  display: boolean = false;
  /** event detail ctor */
  constructor(private service: EventService) {

  }

  toggleDisplay(): void {
    this.display = !this.display;
  }

  ngOnInit(): void {

  }

  //ngOnInit(id: number): void {
  //  this.service.getEventById(id).subscribe((response: any) => {
  //    this.Event.id = response;
  //    console.log(response);
  //  });
  // }
 
}
