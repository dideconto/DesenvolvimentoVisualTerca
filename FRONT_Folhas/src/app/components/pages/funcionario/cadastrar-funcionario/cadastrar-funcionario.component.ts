import { Component, OnInit } from "@angular/core";

@Component({
  selector: "app-cadastrar-funcionario",
  templateUrl: "./cadastrar-funcionario.component.html",
  styleUrls: ["./cadastrar-funcionario.component.css"],
})
export class CadastrarFuncionarioComponent implements OnInit {

  numero1: number = 0;
  numero2: number = 0;

  constructor() {}

  ngOnInit(): void {}

  cadastrar(): void {
    let soma : number = this.numero1 + this.numero2;
    console.log(soma);
  }
  
}
