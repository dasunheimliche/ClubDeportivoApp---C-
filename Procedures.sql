DELIMITER $$
CREATE DEFINER=`sql10668775`@`%` PROCEDURE `AdminLogin`(IN `Usu` VARCHAR(20), IN `Pass` VARCHAR(15))
    NO SQL
begin
  select *
	from admins
		where NombreUsu = Usu and PassUsu = Pass;
end$$
DELIMITER ;

DELIMITER $$
CREATE DEFINER=`sql10668775`@`%` PROCEDURE `BuscarNoSocio`(IN `doc` VARCHAR(20))
    NO SQL
BEGIN
	SELECT *
    FROM noSocios
    WHERE dni = doc;
END$$
DELIMITER ;

DELIMITER $$
CREATE DEFINER=`sql10668775`@`%` PROCEDURE `BuscarSocio`(IN `doc` VARCHAR(20))
    NO SQL
BEGIN

	SELECT *
    FROM socios
    WHERE dni = doc;
    
END$$
DELIMITER ;

DELIMITER $$
CREATE DEFINER=`sql10668775`@`%` PROCEDURE `HabilitarCliente`(IN `doc` VARCHAR(20))
    NO SQL
BEGIN
    UPDATE socios
    SET Habilitado = 1
    WHERE dni = doc;

    UPDATE noSocios
    SET Habilitado = 1
    WHERE dni = doc;
END$$
DELIMITER ;

DELIMITER $$
CREATE DEFINER=`sql10668775`@`%` PROCEDURE `ListarClientes`()
    NO SQL
BEGIN
    SELECT Dni, Nombre, Apellido, Habilitado, Vencimiento, "SOCIO" as Tipo FROM socios

    UNION

    SELECT Dni, Nombre, Apellido, Habilitado, "-" as Vencimiento, "NO SOCIO" as Tipo FROM noSocios;
END$$
DELIMITER ;

DELIMITER $$
CREATE DEFINER=`sql10668775`@`%` PROCEDURE `InsertarPago`(IN `socio` INT, IN `ven` DATE, IN `proxVen` DATE, IN `fechaPago` DATE, IN `mon` INT, IN `modal` VARCHAR(30), IN `type` VARCHAR(20))
    NO SQL
BEGIN
    INSERT INTO pagos (CodSocio, Vencimiento, ProxVencimiento, Fecha, Monto, Modalidad, Tipo)
    VALUES (socio, ven, proxVen, fechaPago, mon, modal, type);
END$$
DELIMITER ;

DELIMITER $$
CREATE DEFINER=`sql10668775`@`%` PROCEDURE `ListarSociosVencidos`()
    NO SQL
BEGIN
    DECLARE fecha_actual DATE;
    SET fecha_actual = CURDATE();

    SELECT *
    FROM socios
    WHERE vencimiento < fecha_actual;
END$$
DELIMITER ;

DELIMITER $$
CREATE DEFINER=`sql10668775`@`%` PROCEDURE `PagarCuota`(IN `doc` VARCHAR(20))
    NO SQL
BEGIN
    DECLARE fechaVencimiento DATE;
    DECLARE nuevaFecha DATE;

    SELECT vencimiento INTO fechaVencimiento
    FROM socios
    WHERE Dni = doc;

    IF CURDATE() > fechaVencimiento THEN
        SET nuevaFecha = CURDATE() + INTERVAL 30 DAY;
    ELSE
        SET nuevaFecha = fechaVencimiento + INTERVAL 30 DAY;
    END IF;

    UPDATE socios
    SET vencimiento = nuevaFecha
    WHERE Dni = doc;

END$$
DELIMITER ;

DELIMITER $$
CREATE DEFINER=`sql10668775`@`%` PROCEDURE `RegistrarNoSocio`(IN `nombre` VARCHAR(30), IN `apellido` VARCHAR(40), IN `doc` VARCHAR(20), IN `habilitado` TINYINT, OUT `rta` INT)
    NO SQL
begin
     declare filas int default 0;
	 declare existe int default 0;
    
     set filas = (select count(*) from noSocios);
     if filas = 0 then
		set filas = 452; 
     else
		set filas = (select max(CodNoSocio) + 1 from noSocios);

		set existe = (select count(*) from noSocios where Dni = doc);
     end if;
	 
	  if existe = 0 then	 
		 INSERT INTO noSocios (CodNoSocio, Nombre, Apellido, Dni, Habilitado)
VALUES (filas, nombre, apellido, doc, Habilitado);
		 set rta  = filas;
	  else
		 set rta = existe;
      end if;		 
    
     end$$
DELIMITER ;

DELIMITER $$
CREATE DEFINER=`sql10668775`@`%` PROCEDURE `RegistrarSocio`(IN `nombre` VARCHAR(30), IN `apellido` VARCHAR(40), IN `doc` VARCHAR(20), IN `habilitado` TINYINT, IN `vencimiento` DATE, OUT `rta` INT)
    NO SQL
begin
     declare filas int default 0;
	 declare existe int default 0;
    
     set filas = (select count(*) from socios);
     if filas = 0 then
		set filas = 452; 
     else
		set filas = (select max(CodSocio) + 1 from socios);

		set existe = (select count(*) from socios where Dni = doc);
     end if;
	 
	  if existe = 0 then	 
		 INSERT INTO socios (CodSocio, Nombre, Apellido, Dni, Habilitado, Vencimiento)
VALUES (filas, nombre, apellido, doc, Habilitado, vencimiento);
		 set rta  = filas;
	  else
		 set rta = existe;
      end if;		 
    
     end$$
DELIMITER ;
