interface IDAO<T>
{
    public void Cadastrar(T objeto);
    public void Atualizar(T objet);
    public void Excluir(T objeto);
    public List<T> ListarTodos();
    public T ListarPorId(int id);
}