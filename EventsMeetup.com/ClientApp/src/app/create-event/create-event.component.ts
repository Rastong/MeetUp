import { Component } from '@angular/core';
import { NgForm } from '@angular/forms';
import { EventService } from '../event.service';
import { EventList } from '../EventList';

@Component({
    selector: 'app-create-event',
    templateUrl: './create-event.component.html',
    styleUrls: ['./create-event.component.css']
})
/** CreateEvent component*/
export class CreateEventComponent {
    /** CreateEvent ctor */
    constructor(private service:EventService) {

  }
  addToEvents(form: NgForm): any {
    let result: EventList = {
      id:0,
      name: form.form.value.Name,
      host: form.form.value.Host,
      categoryID: form.form.value.CategoryID,
      summary: form.form.value.Summary,
      photo: form.form.value.Photo,
      dateAndTime: form.form.value.DateAndTime,
      guestCount: form.form.value.GuestCount,
      spotsFilled: form.form.value.SpotsFilled
    };
    this.service.postEvent(result).subscribe((response: any) => {
      console.log(response);
    });

  }
}
