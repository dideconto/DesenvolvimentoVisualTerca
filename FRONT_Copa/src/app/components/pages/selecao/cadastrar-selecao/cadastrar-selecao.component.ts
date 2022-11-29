import { HttpClient } from "@angular/common/http";
import { Component, OnInit } from "@angular/core";
import { MatSnackBar } from "@angular/material/snack-bar";
import { Router } from "@angular/router";
import { Selecao } from "src/app/models/selecao.model";

@Component({
  selector: "app-cadastrar-selecao",
  templateUrl: "./cadastrar-selecao.component.html",
  styleUrls: ["./cadastrar-selecao.component.css"],
})
export class CadastrarSelecaoComponent implements OnInit {
  nome!: string;

  constructor(
    private http: HttpClient,
    private router: Router,
    private _snackBar: MatSnackBar
  ) {}

  ngOnInit(): void {}

  cadastrar(): void {
    let selecao: Selecao = {
      nome: this.nome,
    };

    this.http
      .post<Selecao>("https://localhost:5001/api/selecao/cadastrar", selecao)
      .subscribe({
        next: (funcionario) => {
          this._snackBar.open("Seleção cadastrada!", "Ok!", {
            horizontalPosition: "right",
            verticalPosition: "top",
          });
          this.router.navigate(["pages/funcionario/listar"]);
        },
        error: (error) => {
          console.error("Algum erro aconteceu!");
        },
      });
  }
}
