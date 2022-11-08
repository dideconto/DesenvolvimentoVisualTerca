import { HttpClient } from "@angular/common/http";
import { Component, OnInit } from "@angular/core";
import { Router } from "@angular/router";
import { Folha } from "src/app/models/Folha";
import { Funcionario } from "src/app/models/Funcionario";

@Component({
  selector: "app-cadastrar-folha",
  templateUrl: "./cadastrar-folha.component.html",
  styleUrls: ["./cadastrar-folha.component.css"],
})
export class CadastrarFolhaComponent implements OnInit {
  //Template - Material Design Angular

  valor!: number;
  quantidade!: number;
  data!: string;
  funcionarios!: Funcionario[];
  funcionarioId!: number;

  constructor(private http: HttpClient, private router: Router) {}

  ngOnInit(): void {
    //Configuração da requisição
    this.http
      .get<Funcionario[]>("https://localhost:5001/api/funcionario/listar")
      // Execução da requisição
      .subscribe({
        next: (funcionarios) => {
          // console.table(funcionarios);
          this.funcionarios = funcionarios;
        },
      });
  }

  cadastrar(): void {
    let dataConvertida = new Date(this.data);
    let folha: Folha = {
      valorHora: this.valor,
      quantidadeHoras: this.quantidade,
      mes: dataConvertida.getMonth() + 1,
      ano: dataConvertida.getFullYear(),
      funcionarioId: this.funcionarioId,
    };
    console.log(folha);
    this.http
      .post<Folha>("https://localhost:5001/api/folha/cadastrar", folha)
      .subscribe({
        next: (funcionario) => {
          console.log(funcionario);
          this.router.navigate(["pages/folha/listar"]);
        },
      });
  }
}
