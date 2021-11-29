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

  ngOnInit() {
    this.resetForm();

  }
  resetForm(form?: NgForm) {
    if (form != null)
      form.resetForm();

    this.service.formData = {
      id: 0,
      name: "",
      host: "",
      categoryID: 0,
      summary: "",
      photo: "",
      dateAndTime: "",
      guestCount: 0,
      spotsFilled: false
    }
  }


  addToEvents(form: NgForm): any {
    console.log(form.form.value.Date);
    console.log(form.form.value.Time);
    let dT: string = form.form.value.Date + "T" + form.form.value.Time + ":00";
    console.log(dT);
    let result: EventList = {
      id:0,
      name: form.form.value.Name,
      host: form.form.value.Host,
      categoryID: form.form.value.CategoryID,
      summary: form.form.value.Summary,
      photo: form.form.value.Photo,      
      dateAndTime: dT,
      guestCount: form.form.value.GuestCount,
      spotsFilled: false
    };
    this.service.postEvent(result).subscribe((response: any) => {
      console.log(response);
      this.resetForm(form);
    });

  }
}
