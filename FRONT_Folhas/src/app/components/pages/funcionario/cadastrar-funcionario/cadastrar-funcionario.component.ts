import { HttpClient } from "@angular/common/http";
import { Component, OnInit } from "@angular/core";
import { ActivatedRoute, Router } from "@angular/router";
import { Funcionario } from "src/app/models/Funcionario";

@Component({
  selector: "app-cadastrar-funcionario",
  templateUrl: "./cadastrar-funcionario.component.html",
  styleUrls: ["./cadastrar-funcionario.component.css"],
})
export class CadastrarFuncionarioComponent implements OnInit {
  nome!: string;
  cpf!: string;
  erro!: string;

  constructor(
    private http: HttpClient,
    private router: Router,
    private route: ActivatedRoute
  ) {}

  ngOnInit(): void {
    this.route.params.subscribe((params) => {
      let { id } = params;
      if(id !== undefined){
        console.log(id);
      }
    });
  }

  cadastrar(): void {
    let funcionario: Funcionario = {
      nome: this.nome,
      cpf: this.cpf,
      email: "diogo@diogo.com",
      salario: 950,
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
        //Aqui executamos algo quando a requisição for bem-sucedida
        next: (funcionario) => {
          this.router.navigate(["pages/funcionario/listar"]);
        },
        //Aqui executamos algo quando a requisição for mal-sucedida
        error: (error) => {
          if(error.status == 400){
            this.erro = "Erro de validação";
          }else if(error.status == 0){
            this.erro = "Está faltando iniciar a sua API!";
          }
        },
      });
  }
}
