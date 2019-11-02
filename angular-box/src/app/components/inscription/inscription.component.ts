import { Component, OnInit } from '@angular/core';
import { FormGroup, FormControl, Validators } from '@angular/forms';
import { PoepleService } from 'src/app/services/people.service';



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

  constructor(private peopleInscription: PoepleService) { 
    this.forminscription = new FormGroup(
      {
        C_Nom: new FormControl(null,{validators: [
          //verification (condition)
          Validators.maxLength(50),
          Validators.required
        ]}),
         LastName: new FormControl(null,{validators:[
           Validators.maxLength(50),
           Validators.required

         ]}),
         Email: new FormControl(null,{validators:[
           Validators.maxLength(50),
           Validators.required
         ]}),
         Birthdate: new FormControl(null,{validators:[
           Validators.required
         ]}),
         Gsm: new FormControl(null,{validators:[
           Validators.maxLength(50),
           

         ]}),
         Password: new FormControl(null,{validators:[
          Validators.maxLength(50),
          Validators.required

        ]})
      })
  }

  ngOnInit() {
  }
 
}
