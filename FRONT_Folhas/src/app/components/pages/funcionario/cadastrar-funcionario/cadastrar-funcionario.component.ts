import { Component, OnInit } from "@angular/core";

@Component({
  selector: "app-cadastrar-funcionario",
  templateUrl: "./cadastrar-funcionario.component.html",
  styleUrls: ["./cadastrar-funcionario.component.css"],
})
export class CadastrarFuncionarioComponent implements OnInit {

  numero1!: string;
  numero2!: string;
  soma!: number;

  constructor() {}

  ngOnInit(): void {}

  cadastrar(): void {
    this.soma = 
      Number.parseInt(this.numero1) + 
      Number.parseInt(this.numero2);

    console.log(this.soma);


  }
  
}
