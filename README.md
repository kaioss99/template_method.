# template_method

Trabalho Design Patterns

---

## **Design Pattern GoF — Template Method**

Projeto desenvolvido em **C# com WPF (.NET)** aplicando o padrão **Template Method**.

---

## **Sobre o Projeto**

Sistema de geração de relatórios com suporte a:

- **HTML**
- **PDF**
- **CSV**

Todos seguem a mesma estrutura, mudando apenas a implementação.

---

## **O que é Template Method?**

É um padrão que define o **esqueleto de um algoritmo** em uma classe base, permitindo que subclasses implementem partes específicas.

> "Não nos chame, nós chamamos você"

---

## **Problema Resolvido**

Sem o padrão:
- Código duplicado
- Difícil manutenção
- Inconsistência

Com o padrão:
- Código centralizado
- Fácil extensão
- Estrutura padronizada

---

## **Estrutura**

- **AbstractClass** → define o fluxo
- **ConcreteClass** → implementa os detalhes

---

### **Classe Base**

```csharp
public abstract class ReportBase
{
    public sealed void GenerateReport(string outputPath)
    {
        var data = CollectData();
        var processed = ProcessData(data);
        AddHeader();
        ExportReport(processed, outputPath);
        AddFooter();
    }

    protected abstract List<SaleRecord> CollectData();
    protected abstract string ProcessData(List<SaleRecord> data);
    protected abstract void ExportReport(string content, string path);

    protected virtual void AddHeader() { }
    protected virtual void AddFooter() { }
}
```


## **Vantagens**

- Reutilização de código  
- Padronização  
- Fácil manutenção  
- Extensível  

---

## ** Desvantagens**

- Forte acoplamento  
- Dependência de herança  
- Menos flexível que Strategy  

---

## **Exemplos Reais**

- ASP.NET Core  
- Entity Framework  
- Android  
- JUnit  
- Spring  

---

## **Conclusão**

O Template Method permite criar sistemas organizados, reutilizáveis e fáceis de manter, sendo muito usado no mercado.

---

## **Tecnologias**

- C#
- .NET
- WPF
- MVVM
