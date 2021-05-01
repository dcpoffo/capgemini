import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { HomeComponent } from './views/home/home.component';

//Pessoa
import { PessoaCrudComponent } from './views/pessoa-crud/pessoa-crud.component'
import { PessoaUpdateComponent } from './components/pessoa/pessoa-update/pessoa-update.component';
import { PessoaCreateComponent } from './components/pessoa/pessoa-create/pessoa-create.component';
import { PessoaDeleteComponent } from './components/pessoa/pessoa-delete/pessoa-delete.component';

const routes: Routes = [
  { path: '', component: HomeComponent },

  //Pessoa
  {path: 'pessoas', component: PessoaCrudComponent},
  {path: 'pessoas/create', component: PessoaCreateComponent},
  {path: 'pessoas/update/:id', component: PessoaUpdateComponent},
  {path: 'pessoas/delete/:id', component: PessoaDeleteComponent},
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
