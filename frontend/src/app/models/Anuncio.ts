export class Anuncio {
  id?: number;
  nome: string;
  clienteId: number;
  dataInicio: Date;
  dataTermino: Date;
  investimentoDiario: number;
  qtdDias: number;

  constructor() {
    this.id = 0;
    this.nome  = '';
    this.clienteId = 0;
    this.dataInicio = null;
    this.dataTermino = null;
    this.investimentoDiario = 1.0;
    this.qtdDias = 0;
      }
}
