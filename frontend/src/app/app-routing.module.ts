import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { HomeComponent } from './views/home/home.component';

//Cliente
import { ClienteCrudComponent  } from './views/cliente-crud/cliente-crud.component';
import { ClienteCreateComponent  } from './components/cliente/cliente-create/cliente-create.component';
import { ClienteDeleteComponent  } from './components/cliente/cliente-delete/cliente-delete.component';
import { ClienteUpdateComponent  } from './components/cliente/cliente-update/cliente-update.component';

//Anuncios
import { AnuncioCrudComponent  } from './views/anuncio-crud/anuncio-crud.component';
import { AnuncioCreateComponent  } from './components/anuncio/anuncio-create/anuncio-create.component';
import { AnuncioDeleteComponent  } from './components/anuncio/anuncio-delete/anuncio-delete.component';
import { AnuncioUpdateComponent  } from './components/anuncio/anuncio-update/anuncio-update.component';

//Relatorio
import { RelatorioComponent } from './components/relatorio/relatorio.component';

const routes: Routes = [
  { path: '', component: HomeComponent },

  //Cliente
  {path: 'clientes', component: ClienteCrudComponent},
  {path: 'clientes/create', component: ClienteCreateComponent},
  {path: 'clientes/update/:id', component: ClienteUpdateComponent},
  {path: 'clientes/delete/:id', component: ClienteDeleteComponent},

  //Anuncios
  {path: 'anuncios', component: AnuncioCrudComponent},
  {path: 'anuncios/create', component: AnuncioCreateComponent},
  {path: 'anuncios/update/:id', component: AnuncioUpdateComponent},
  {path: 'anuncios/delete/:id', component: AnuncioDeleteComponent},

  {path: 'relatorios', component: RelatorioComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
