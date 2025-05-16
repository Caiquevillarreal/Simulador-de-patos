namespace SimuladorPatosForms
{
    public abstract class Pato
    {
        public abstract string FazerSom();
    }

    public class PatoReal : Pato
    {
        public override string FazerSom() => "Quack!";
    }

    public class PatoDeBorracha : Pato
    {
        public override string FazerSom() => "Squeak!";
    }

    public class PatoDeMadeira : Pato
    {
        public override string FazerSom() => "Sem barulho";
    }

    public class PatoCabecaVermelha : Pato
    {
        public override string FazerSom() => "Quaaaack!";
    }
    public class PatoPatolino : Pato
    {
        public override string FazerSom() => "Quackk";
    }
    public class PatoAzul : Pato
    {
        public override string FazerSom() => "Pluft!";
    }
    public class PatoTioPatinhas : Pato
    {
        public override string FazerSom() => "Sou milionario!";
    }


}
