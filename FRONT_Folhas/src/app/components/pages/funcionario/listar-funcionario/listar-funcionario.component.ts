import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { Funcionario } from 'src/app/models/Funcionario';

@Component({
  selector: 'app-listar-funcionario',
  templateUrl: './listar-funcionario.component.html',
  styleUrls: ['./listar-funcionario.component.css']
})
export class ListarFuncionarioComponent implements OnInit {

  //ngFor
  funcionarios!: Funcionario[];

  constructor(private http: HttpClient) { }

  ngOnInit(): void {
    //Configuração da requisição
    this.http.get<Funcionario[]>
      ("https://localhost:5001/api/funcionario/listar")
      // Execução da requisição
      .subscribe({
        next: (funcionarios) => {
          // console.table(funcionarios);
          this.funcionarios = funcionarios;
        }
      });
  }

  deletar(id: number): void{
    this.http.delete<Funcionario>
      (`https://localhost:5001/api/funcionario/deletar/${id}`)
      .subscribe({
        next: (funcionario) => {
          this.ngOnInit();
        },
      });
  }

}
