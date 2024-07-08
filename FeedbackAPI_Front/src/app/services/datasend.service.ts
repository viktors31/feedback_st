import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class DatasendService {
  private sendmessageurl = 'http://localhost:5163/api/message';
  private gettopicsurl = 'http://localhost:5163/api/messagetopic';

  constructor(private httpClient: HttpClient) { 

  }

  //Получение топиков, вернет лист топиков без id
  getTopics(){
    return this.httpClient.get(this.gettopicsurl);
  }
}
