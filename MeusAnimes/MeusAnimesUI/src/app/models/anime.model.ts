import { EnumClassificacao } from "../enums/classificacao.enum";
import { EnumGenero } from "../enums/genero.enum";

export class Anime {
  name: string = "";
  Description: string = "";
  genero: EnumGenero = 0;
  releaseDate: Date = new Date();
  classificacao: EnumClassificacao = 0;
}
