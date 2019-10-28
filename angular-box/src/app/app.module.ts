import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';


import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { NbThemeModule, NbLayoutModule, NbSidebarModule, NbMenuModule, NbButtonModule, NbInputModule, NbListModule, NbCardModule, NbIconModule, NbDialogModule } from '@nebular/theme';
import { NbEvaIconsModule } from '@nebular/eva-icons';
import { InscriptionComponent } from './components/inscription/inscription.component';
import { ConnectionComponent } from './components/connection/connection.component';
import { FormsModule } from '@angular/forms';
import { NavComponent } from './components/nav/nav.component';
//ng module est une declaration de temps les component module et providers que l app 
//vas utiliser 
// un module c'est une sorte de librairie si on veux l utilisé on doit l importer 
// dans le ng module 
@NgModule({
  declarations: [
    AppComponent,
    InscriptionComponent,
    ConnectionComponent,
    NavComponent
   

  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    NbThemeModule.forRoot({ name: 'cosmic' }),
    NbLayoutModule,
    NbEvaIconsModule,
    NbSidebarModule.forRoot(),
    NbMenuModule.forRoot(),
    NbButtonModule,
    NbInputModule,
    FormsModule,
    NbListModule,
    NbCardModule,
    NbIconModule,
    NbDialogModule.forRoot(),
    HttpClientModule,
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
