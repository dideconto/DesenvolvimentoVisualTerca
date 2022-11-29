import { Jogo } from "./../../../../models/jogo.model";
import { HttpClient } from "@angular/common/http";
import { Component, OnInit } from "@angular/core";
import { Selecao } from "src/app/models/selecao.model";
import { ActivatedRoute, Router } from "@angular/router";
import { MatSnackBar } from "@angular/material/snack-bar";

@Component({
  selector: "app-cadastrar-jogo",
  templateUrl: "./cadastrar-jogo.component.html",
  styleUrls: ["./cadastrar-jogo.component.css"],
})
export class CadastrarJogoComponent implements OnInit {
  id!: number;
  selecaoAId!: number;
  selecaoBId!: number;
  selecoes!: Selecao[];
  placarA!: number;
  placarB!: number;

  constructor(
    private http: HttpClient,
    private router: Router,
    private _snackBar: MatSnackBar
  ) {}

  ngOnInit(): void {
    this.http
      .get<Selecao[]>("https://localhost:5001/api/selecao/listar")
      .subscribe({
        next: (selecoes) => {
          this.selecoes = selecoes;
        },
      });
  }

  cadastrar(): void {
    let jogo: Jogo = {
      selecaoAId: this.selecaoAId,
      selecaoBId: this.selecaoBId,
    };

    this.http
      .post<Jogo>("https://localhost:5001/api/jogo/cadastrar", jogo)
      .subscribe({
        next: (jogo) => {
          this._snackBar.open("Jogo cadastrado!", "Ok!", {
            horizontalPosition: "right",
            verticalPosition: "top",
          });
          this.router.navigate(["pages/jogo/listar"]);
        },
        error: (error) => {
          console.error("Algum erro aconteceu!", error);
        },
      });
  }
}
