/*
 * Создать свой интерфейс IMyCloneable для реализации шаблона "Прототип".
 */
public interface IMyCloneable<out T>
{
    T Clone();
}



