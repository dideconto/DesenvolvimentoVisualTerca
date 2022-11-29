import { Selecao } from "./selecao.model";

export interface Jogo {
  id?: number;
  selecaoAId: number;
  selecaoA?: Selecao;
  placarA?: number;
  selecaoBId: number;
  selecaoB?: Selecao;
  placarB?: number;
  criadoEm?: string;
}
