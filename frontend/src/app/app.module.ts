import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { HttpClientModule } from '@angular/common/http';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';

import { MatCardModule } from '@angular/material/card';
import { MatSnackBarModule } from '@angular/material/snack-bar';
import { MatToolbarModule } from '@angular/material/toolbar';
import { MatSidenavModule } from '@angular/material/sidenav';
import { MatListModule } from '@angular/material/list';
import { MatTableModule } from '@angular/material/table';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatInputModule } from '@angular/material/input';
import { MatButtonModule } from '@angular/material/button';
import { MatSelectModule } from '@angular/material/select';
import { MatDatepickerModule } from '@angular/material/datepicker';
import { MatNativeDateModule, MAT_DATE_LOCALE } from '@angular/material/core';

import { HomeComponent } from './views/home/home.component';
import { HeaderComponent } from './components/templante/header/header.component';
import { FooterComponent } from './components/templante/footer/footer.component';
import { NavComponent } from './components/templante/nav/nav.component';

//Clientes
import { ClienteCrudComponent  } from './views/cliente-crud/cliente-crud.component';
import { ClienteReadComponent  } from './components/cliente/cliente-read/cliente-read.component';
import { ClienteCreateComponent  } from './components/cliente/cliente-create/cliente-create.component';
import { ClienteDeleteComponent  } from './components/cliente/cliente-delete/cliente-delete.component';
import { ClienteUpdateComponent  } from './components/cliente/cliente-update/cliente-update.component';

//Anuncios
import { AnuncioCrudComponent  } from './views/anuncio-crud/anuncio-crud.component';
import { AnuncioReadComponent  } from './components/anuncio/anuncio-read/anuncio-read.component';
import { AnuncioCreateComponent  } from './components/anuncio/anuncio-create/anuncio-create.component';
import { AnuncioDeleteComponent  } from './components/anuncio/anuncio-delete/anuncio-delete.component';
import { AnuncioUpdateComponent  } from './components/anuncio/anuncio-update/anuncio-update.component';


@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    HeaderComponent,
    FooterComponent,
    NavComponent,

    ClienteReadComponent,
    ClienteCrudComponent,
    ClienteCreateComponent,
    ClienteDeleteComponent,
    ClienteUpdateComponent,

    AnuncioCrudComponent,
    AnuncioReadComponent,
    AnuncioCreateComponent,
    AnuncioDeleteComponent,
    AnuncioUpdateComponent,

  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    MatToolbarModule,
    MatSidenavModule,
    MatListModule,
    MatSnackBarModule,
    MatTableModule,
    MatFormFieldModule,
    MatInputModule,
    MatButtonModule,
    MatSelectModule,
    MatDatepickerModule,
    MatCardModule,
    HttpClientModule,
    FormsModule,
    ReactiveFormsModule,
    MatNativeDateModule
  ],
  providers: [
    MatFormFieldModule,
    MatDatepickerModule,
    { provide: MAT_DATE_LOCALE, useValue: 'pt-BR' }
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
