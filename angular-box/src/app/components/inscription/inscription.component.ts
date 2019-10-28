import { Component, OnInit } from '@angular/core';
import { FormGroup, FormControl, Validators } from '@angular/forms';
import { PoepleRepository } from 'src/app/services/poeple.service';
import { type } from 'os';

@Component({
  selector: 'app-inscription',
  templateUrl: './inscription.component.html',
  styleUrls: ['./inscription.component.scss']
})
export class InscriptionComponent implements OnInit {
  
 //cree un formulair 1 : une presonne 
  private _forminscription : FormGroup;
  public get forminscription() : FormGroup {
    return this._forminscription;
  }
  public set forminscription(v : FormGroup) {
    this._forminscription = v;
  }

  constructor(private peopleInscription: PoepleRepository) { 
    this.forminscription = new FormGroup(
      {
        C_Nom: new FormControl(null,{validators: [
          //verification (condition)
          Validators.maxLength(50)
        ]}),
      })
  }

  ngOnInit() {
  }
 
}
