import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { Funcionario } from 'src/app/models/Funcionario';

@Component({
  selector: 'app-listar-funcionario',
  templateUrl: './listar-funcionario.component.html',
  styleUrls: ['./listar-funcionario.component.css']
})
export class ListarFuncionarioComponent implements OnInit {

  funcionarios!: Funcionario[];

  constructor(private http: HttpClient) { }

  ngOnInit(): void {
    //Configuração da requisição
    this.http.get<Funcionario[]>
      ("https://localhost:5001/api/funcionario/listar")
      // Execução da requisição
      .subscribe({
        next: (funcionarios) => {
          this.funcionarios = funcionarios;
        }
      });
  }

}
