import { HttpClient } from "@angular/common/http";
import { Component, OnInit } from "@angular/core";
import { Jogo } from "src/app/models/jogo.model";

@Component({
  selector: "app-listar-jogo",
  templateUrl: "./listar-jogo.component.html",
  styleUrls: ["./listar-jogo.component.css"],
})
export class ListarJogoComponent implements OnInit {
  jogos!: Jogo[];

  constructor(private http: HttpClient) {}

  ngOnInit(): void {
    this.http.get<Jogo[]>("https://localhost:5001/api/jogo/listar").subscribe({
      next: (jogos) => {
        this.jogos = jogos;
      },
    });
  }
}
