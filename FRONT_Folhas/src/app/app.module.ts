import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { CadastrarFuncionarioComponent } from './components/pages/funcionario/cadastrar-funcionario/cadastrar-funcionario.component';
import { ListarFuncionarioComponent } from './components/pages/funcionario/listar-funcionario/listar-funcionario.component';

@NgModule({
  declarations: [
    AppComponent,
    CadastrarFuncionarioComponent,
    ListarFuncionarioComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
