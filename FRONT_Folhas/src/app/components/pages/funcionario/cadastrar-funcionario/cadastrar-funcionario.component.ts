import { HttpClient } from "@angular/common/http";
import { Component, OnInit } from "@angular/core";
import { MatSnackBar } from "@angular/material/snack-bar";
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
  email!: string;
  nascimento!: string;
  funcionarioId!: number;
  erro!: string;

  constructor(
    private http: HttpClient,
    private router: Router,
    private route: ActivatedRoute,
    private _snackBar: MatSnackBar
  ) {}

  ngOnInit(): void {
    this.route.params.subscribe((params) => {
      let { id } = params;
      if (id !== undefined) {
        this.http.get<Funcionario>(`https://localhost:5001/api/funcionario/buscar/${id}`).subscribe({
          next: (funcionario) => {
            this.nome = funcionario.nome;
            this.cpf = funcionario.cpf;
            this.funcionarioId = funcionario.id!;
          },
        });
      }
    });
  }

  alterar(): void {
    let funcionario: Funcionario = {
      id: this.funcionarioId,
      nome: this.nome,
      cpf: this.cpf,
      email: this.email,
      salario: 950,
      nascimento: this.nascimento,
    };
    //Configuração da requisição
    this.http
      .patch<Funcionario>("https://localhost:5001/api/funcionario/alterar", funcionario)
      //Execução da requisição
      .subscribe({
        //Aqui executamos algo quando a requisição for bem-sucedida
        next: (funcionario) => {
          this._snackBar.open("Funcionário alterado!", "Ok!", {
            horizontalPosition: "right",
            verticalPosition: "top",
          });
          this.router.navigate(["pages/funcionario/listar"]);
        },
        //Aqui executamos algo quando a requisição for mal-sucedida
        error: (error) => {
          if (error.status == 400) {
            this.erro = "Erro de validação";
          } else if (error.status == 0) {
            this.erro = "Está faltando iniciar a sua API!";
          }
        },
      });
  }

  cadastrar(): void {
    let funcionario: Funcionario = {
      nome: this.nome,
      cpf: this.cpf,
      email: this.email,
      salario: 950,
      nascimento: this.nascimento,
    };
    //Configuração da requisição
    this.http
      .post<Funcionario>("https://localhost:5001/api/funcionario/cadastrar", funcionario)
      //Execução da requisição
      .subscribe({
        //Aqui executamos algo quando a requisição for bem-sucedida
        next: (funcionario) => {
          this._snackBar.open("Funcionário cadastrado!", "Ok!", {
            horizontalPosition: "right",
            verticalPosition: "top",
          });
          this.router.navigate(["pages/funcionario/listar"]);
        },
        //Aqui executamos algo quando a requisição for mal-sucedida
        error: (error) => {
          if (error.status == 400) {
            this.erro = "Erro de validação";
          } else if (error.status == 0) {
            this.erro = "Está faltando iniciar a sua API!";
          }
        },
      });
  }
}
