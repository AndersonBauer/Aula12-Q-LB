Empresa empresa = new Empresa();
Funcionario func1 = new Funcionario("Anderson", 21);
Gerente gerente = new Gerente("Lucas", 30, 2000);
Estagiario estragiario = new Estagiario("Pedro",18);

empresa.AdcionarFuncionario(func1);
empresa.AdcionarFuncionario(gerente);
empresa.AdcionarFuncionario(estragiario);

empresa.ListarFuncionarios();