import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { InscriptionComponent } from './components/inscription/inscription.component';
import { ConnectionComponent } from './components/connection/connection.component';


const routes: Routes = [
  {path :'Inscription', component: InscriptionComponent},
  {path : 'Connection', component: ConnectionComponent}

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
