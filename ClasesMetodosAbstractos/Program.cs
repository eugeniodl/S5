FormaDePago pago1 = new PagoConTarjeta(100, "1234-5678-9876-5432");
pago1.ProcesarPago();

FormaDePago pago2 = new PagoConTransferencia(250, "AB1234567890");
pago2.ProcesarPago();
