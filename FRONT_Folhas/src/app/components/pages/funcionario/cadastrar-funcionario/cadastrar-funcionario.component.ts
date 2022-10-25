import { HttpClient } from "@angular/common/http";
import { Component, OnInit } from "@angular/core";
import { Funcionario } from "src/app/models/Funcionario";

@Component({
  selector: "app-cadastrar-funcionario",
  templateUrl: "./cadastrar-funcionario.component.html",
  styleUrls: ["./cadastrar-funcionario.component.css"],
})
export class CadastrarFuncionarioComponent implements OnInit {
  nome!: string;
  cpf!: string;

  constructor(private http: HttpClient) {}

  ngOnInit(): void {

  }

  cadastrar(): void {
    let funcionario: Funcionario = {
      nome: this.nome,
      cpf: this.cpf,
      email: "diogo@diogo.com",
      salario: 950,
      criadoEm: "2022-10-25",
      nascimento: "2022-10-25",
    };
    //Configuração da requisição
    this.http
      .post<Funcionario>(
        "https://localhost:5001/api/funcionario/cadastrar",
        funcionario
      )
      //Execução da requisição
      .subscribe({
        next: (funcionario) => {
          //Aqui executamos algo quando a requisição for bem sucedida
          console.log("Cadastramos!");
        },
      });

    console.log(funcionario);
  }
}
