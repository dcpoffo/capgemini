import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { Pessoa } from 'src/app/models/Pessoa';
import { MensagemService } from 'src/app/services/mensagem.service';
import { PessoaService } from 'src/app/services/pessoa.service';

@Component({
  selector: 'app-pessoa-delete',
  templateUrl: './pessoa-delete.component.html',
  styleUrls: ['./pessoa-delete.component.scss']
})
export class PessoaDeleteComponent implements OnInit {

  pessoa: Pessoa = {
    nome: '',
    sobrenome: ''
  };

  constructor(
    private pessoaServico: PessoaService,
    private mensagemServico: MensagemService,
    private router: Router,
    private route: ActivatedRoute
  ) { }

  ngOnInit() {
    const id = +this.route.snapshot.paramMap.get('id');
    this.pessoaServico.getById(id).subscribe((pessoa) => {
      this.pessoa = pessoa;
    });
  }

  apagar(): void {
    this.pessoaServico.delete(this.pessoa.id).subscribe(() => {
      this.mensagemServico.showMessage('Pessoa excluida com sucesso!');

      this.router.navigate(['/pessoas']);
    });
  }

  cancelar(): void {
    this.router.navigate(['/pessoas']);
  }
}
