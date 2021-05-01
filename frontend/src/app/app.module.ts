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

//Pessoas
import { PessoaCrudComponent  } from './views/pessoa-crud/pessoa-crud.component';
import { PessoaReadComponent  } from './components/pessoa/pessoa-read/pessoa-read.component';
import { PessoaCreateComponent  } from './components/pessoa/pessoa-create/pessoa-create.component';
import { PessoaDeleteComponent  } from './components/pessoa/pessoa-delete/pessoa-delete.component';
import { PessoaUpdateComponent  } from './components/pessoa/pessoa-update/pessoa-update.component';


@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    HeaderComponent,
    FooterComponent,
    NavComponent,
    PessoaReadComponent,

    PessoaCrudComponent,
    PessoaCreateComponent,
    PessoaDeleteComponent,
    PessoaUpdateComponent,

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
