import { Component } from '@angular/core';
import { SoftrustFormComponent } from './softrustform/softrustform.component';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [
    SoftrustFormComponent
  ],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent {
  title = 'FeedbackAPI_Front';
}
