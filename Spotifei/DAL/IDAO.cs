interface IDAO<T>
{
    public void Cadastrar(T objeto);
    public void Atualizar(T objeto);
    public void Excluir(int id);
    public List<T> ListarTodos();
    public T Listar(int id);
}