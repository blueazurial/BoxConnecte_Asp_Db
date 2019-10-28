import { Component, OnInit } from '@angular/core';
import { NbMenuModule } from '@nebular/theme';

@Component({
  selector: 'app-nav',
  templateUrl: './nav.component.html',
  styleUrls: ['./nav.component.scss']
})
export class NavComponent implements OnInit {

  items: NbMenuModule[] = [
    {title : 'Inscription', icon:'star' ,link:'/Inscription'},
    {title : ' Connexion', icon: 'star', link : '/Connection'}
  ]

  constructor() { }

  ngOnInit() {
  }

}
