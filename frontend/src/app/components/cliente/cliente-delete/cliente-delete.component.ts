import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { Cliente } from 'src/app/models/Cliente';
import { ClienteService } from 'src/app/services/Cliente.service';
import { MensagemService } from 'src/app/services/mensagem.service';

@Component({
  selector: 'app-cliente-delete',
  templateUrl: './cliente-delete.component.html',
  styleUrls: ['./cliente-delete.component.scss']
})
export class ClienteDeleteComponent implements OnInit {

  cliente: Cliente = {
    nome: ''
  };

  constructor(
    private clienteServico: ClienteService,
    private mensagemServico: MensagemService,
    private router: Router,
    private route: ActivatedRoute
  ) { }

  ngOnInit() {
    const id = +this.route.snapshot.paramMap.get('id');
    this.clienteServico.getById(id).subscribe((cliente) => {
      this.cliente = cliente;
    });
  }

  apagar(): void {
    this.clienteServico.delete(this.cliente.id).subscribe(() => {
      this.mensagemServico.showMessage('Cliente excluido com sucesso!');

      this.router.navigate(['/clientes']);
    });
  }

  cancelar(): void {
    this.router.navigate(['/clientes']);
  }

}
