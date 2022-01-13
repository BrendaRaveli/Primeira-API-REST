import { NgModule } from '@angular/core';
import { Routes } from '@angular/router';
import { RouterModule } from '@angular/router';
import { CadastroComponent } from './produtos/cadastro/cadastro.component';
import { ListaComponent } from './produtos/lista/lista.component';
import { LoginComponent } from './user/login/login.component';
import { BrowserModule } from '@angular/platform-browser';

const routes: Routes = [
  {path: '', component: LoginComponent },
  {path: 'cadastro-produtos', component: CadastroComponent },
  {path: 'lista-produtos', component: ListaComponent },
  {path: 'entrar', component: LoginComponent }  
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
