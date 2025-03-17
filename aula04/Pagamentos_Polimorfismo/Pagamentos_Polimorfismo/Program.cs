using Pagamentos_Polimorfismo;

PagamentoCartao pc = new PagamentoCartao();
PagamentoBoleto pb = new PagamentoBoleto();


pc.ProcessarPagamento();
pc.ProcessarPagamento(12); //processar em 12x

pb.ProcessarPagamento();