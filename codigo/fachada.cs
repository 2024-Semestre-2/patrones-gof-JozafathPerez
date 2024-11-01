using System;  

// Subsistema 1: Gestión de cuentas
public class Cuenta {
    public void ConsultarSaldo() {
        Console.WriteLine("Consultando saldo de la cuenta...");
    }
    public void Depositar(decimal monto) {
        Console.WriteLine($"Depositando {monto} en la cuenta...");
    }
}

// Subsistema 2: Gestión de préstamos
public class Prestamo {
    public void SolicitarPrestamo(decimal monto) {
        Console.WriteLine($"Solicitando préstamo de {monto}...");
    }
    public void PagarPrestamo(decimal monto) {
        Console.WriteLine($"Pagando {monto} de prestamo...");
    }
}

// Subsistema 3: Gestión de tarjetas
public class Tarjeta {
    public void ConsultarLimite() {
        Console.WriteLine("Consultando limite de credito de la tarjeta...");
    }
    public void PagarTarjeta(decimal monto) {
        Console.WriteLine($"Pagando {monto} de la tarjeta de credito...");
    }
}

// Clase Facade: BancoFacade
public class BancoFacade {
    private Cuenta cuenta;
    private Prestamo prestamo;
    private Tarjeta tarjeta;

    public BancoFacade() {
        cuenta = new Cuenta();
        prestamo = new Prestamo();
        tarjeta = new Tarjeta();
    }

    public void ConsultarServiciosBancarios() {
        cuenta.ConsultarSaldo();
        tarjeta.ConsultarLimite();
    }

    public void PagarPrestamo(decimal monto) {
        prestamo.PagarPrestamo(monto);
    }

    public void PagarTarjeta(decimal monto) {
        tarjeta.PagarTarjeta(monto);
    }
}

// Cliente: Interacción con el sistema a través del Facade
public class Cliente {
    public static void Main(string[] args) {
        BancoFacade bancoFacade = new BancoFacade();
        
        bancoFacade.ConsultarServiciosBancarios();
        bancoFacade.PagarPrestamo(5000);
        bancoFacade.PagarTarjeta(1500);
    }
}
