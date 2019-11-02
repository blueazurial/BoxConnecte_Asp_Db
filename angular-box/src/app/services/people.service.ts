import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';


@Injectable({
  providedIn: 'root'
})

export class PoepleService {

  private _enPoint = 'https://localhost:50420/api/poeple';

  
  
}
