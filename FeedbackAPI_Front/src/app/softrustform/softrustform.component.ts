import { Component } from '@angular/core';
//import { DatasendService } from './services/datasend.service';

@Component({
  selector: 'app-softrustform',
  standalone: true,
  imports: [],
  templateUrl: './softrustform.component.html',
  styleUrl: './softrustform.component.css'
})


export class SoftrustFormComponent {
  title = 'SofTrust Form1';
  /*constructor (private service:DatasendService) {}
  ngOnInit() {
    
    this.service.getTopics().subscribe(data => {console.log(data)})
  }*/
}