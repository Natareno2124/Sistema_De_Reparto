CREATE DATABASE SistemaReparto;
USE SistemaReparto;

-- 1. Tablas independientes o sin claves foráneas
CREATE TABLE clientes (
	ID_cliente INT PRIMARY KEY,
	clienteNombre VARCHAR(50),
	clienteApellido VARCHAR(50),
	clienteNIT VARCHAR(15)
);

CREATE TABLE ContactoSucursal (
	id INT AUTO_INCREMENT PRIMARY KEY,
	srcTelefono VARCHAR(9),
	srcCorreo VARCHAR(50)
);

CREATE TABLE DireccionSucursal (
	id INT AUTO_INCREMENT PRIMARY KEY,
	srcCalle VARCHAR(50),
	srcAvenida VARCHAR(50),
	srcZona INT,
	srcCiudad VARCHAR(50),
	srcMunicipio VARCHAR(50)
);

CREATE TABLE Encargado (
	id INT AUTO_INCREMENT PRIMARY KEY,
	nombres VARCHAR(50),
	apellidos VARCHAR(50),
	codigo INT
);

CREATE TABLE tipoRuta (
	ID_TipoRuta INT PRIMARY KEY,
	TipoRuta VARCHAR(20)
);

CREATE TABLE tipoVehiculo (
	idTipo INT PRIMARY KEY,
	nombreTipo VARCHAR(50)
);

CREATE TABLE estadoVehiculo (
	idEstado INT PRIMARY KEY,
	estadoVehiculo VARCHAR(50)
);

CREATE TABLE producto (
	ID_producto INT PRIMARY KEY,
	Nombre VARCHAR(70),
	descripcion VARCHAR(250),
	Precio FLOAT
);

CREATE TABLE tipoPago (
	id INT PRIMARY KEY,
	TipoPago VARCHAR(25)
);

-- 2. Tablas hijas de clientes y encargado
CREATE TABLE Tbl_ClienteDireccion (
	ID_ClienteDireccion INT PRIMARY KEY AUTO_INCREMENT,
	ID_CLIENTE INT,
	Cliente_Calle VARCHAR(50),
	Cliente_Avenida VARCHAR(50),
	Cliente_Zona INT,
	Cliente_Ciudad VARCHAR(100),
	Cliente_Municipio VARCHAR(100),
	Cliente_Latitud DOUBLE,
	Cliente_Longitud DOUBLE,
	FOREIGN KEY (ID_CLIENTE) REFERENCES clientes(ID_cliente)
);

CREATE TABLE Tbl_ClienteContacto (
	ID_ClienteContacto INT PRIMARY KEY AUTO_INCREMENT,
	ID_CLIENTE INT,
	Cliente_Telefono VARCHAR(20),
	Cliente_Correo VARCHAR(100),
	FOREIGN KEY (ID_CLIENTE) REFERENCES clientes(ID_cliente)
);

CREATE TABLE Tbl_EncargadoDireccion (
	ID_EncargadoDireccion INT PRIMARY KEY AUTO_INCREMENT,
	ID_Encargado INT,
	Encargado_Calle VARCHAR(50),
	Encargado_Avenida VARCHAR(50),
	Encargado_Zona INT,
	Encargado_Ciudad VARCHAR(100),
	Encargado_Municipio VARCHAR(100),
	Encargado_Latitud DOUBLE,
	Encargado_Longitud DOUBLE,
	FOREIGN KEY (ID_Encargado) REFERENCES Encargado(id)
);

CREATE TABLE Tbl_EncargadoContacto (
	ID_EncargadoContacto INT PRIMARY KEY AUTO_INCREMENT,
	ID_Encargado INT,
	Encargado_Telefono VARCHAR(20),
	Encargado_Correo VARCHAR(100),
	FOREIGN KEY (ID_Encargado) REFERENCES Encargado(id)
);

-- 3. Sucursal (depende de Encargado, Dirección y Contacto)
CREATE TABLE Sucursal (
	id INT AUTO_INCREMENT PRIMARY KEY,
	srcCodigo INT,
	idEncargado INT,
	idDireccion INT,
	idContacto INT,
	FOREIGN KEY (idEncargado) REFERENCES Encargado(id),
	FOREIGN KEY (idDireccion) REFERENCES DireccionSucursal(id),
	FOREIGN KEY (idContacto) REFERENCES ContactoSucursal(id)
);

-- 4. Conductores y sus tablas hijas
CREATE TABLE conductores (
	id INT AUTO_INCREMENT PRIMARY KEY,
	nombres VARCHAR(50),
	apellidos VARCHAR(50),
	fechaNaci DATE,
	sexo VARCHAR(1),
	tipoLicencia VARCHAR(2),
	idSucursal INT,
	FOREIGN KEY (idSucursal) REFERENCES Sucursal(id)
);

CREATE TABLE Tbl_ConductorDireccion (
	ID_ConductorDireccion INT PRIMARY KEY AUTO_INCREMENT,
	ID_Conductor INT,
	Conductor_Calle VARCHAR(50),
	Conductor_Avenida VARCHAR(50),
	Conductor_Zona INT,
	Conductor_Ciudad VARCHAR(100),
	Conductor_Municipio VARCHAR(100),
	Conductor_Latitud DOUBLE,
	Conductor_Longitud DOUBLE,
	FOREIGN KEY (ID_Conductor) REFERENCES conductores(id)
);

CREATE TABLE Tbl_ConductorContacto (
	ID_ConductorContacto INT PRIMARY KEY AUTO_INCREMENT,
	ID_Conductor INT,
	Conductor_Telefono VARCHAR(20),
	Conductor_Correo VARCHAR(100),
	FOREIGN KEY (ID_Conductor) REFERENCES conductores(id)
);

-- 5. Vehículos
CREATE TABLE Vehiculos (
	iD_Placa INT PRIMARY KEY,
	marca VARCHAR(50),
	modelo VARCHAR(50),
	color VARCHAR(15),
	capacidad VARCHAR(20),
	id_Sucursal INT,
	id_tipo INT,
	id_estado INT,
	FOREIGN KEY (id_Sucursal) REFERENCES Sucursal(id),
	FOREIGN KEY (id_tipo) REFERENCES tipoVehiculo(idTipo),
	FOREIGN KEY (id_estado) REFERENCES estadoVehiculo(idEstado)
);

-- 6. Rutas y evaluación
CREATE TABLE Rutas (
	idRuta INT PRIMARY KEY,
	nombre VARCHAR(50),
	dia DATE,
	horaInicio TIME,
	horaFinal TIME,
	idConductor INT,
	FOREIGN KEY (idConductor) REFERENCES conductores(id)
);

CREATE TABLE Tbl_EvaluacionConductores (
	ID_Evaluacion INT PRIMARY KEY,
	ID_Ruta INT,
	Evaluacion_Calificacion INT,
	Evaluacion_Comentario VARCHAR(255),
	Evaluacion_Fecha DATE,
	FOREIGN KEY (ID_Ruta) REFERENCES Rutas(idRuta)
);

-- 7. Bodega (requiere Encargado y Sucursal)
CREATE TABLE Bodega (
	ID_Bodega INT PRIMARY KEY AUTO_INCREMENT,
	codigoBodega INT,
	ID_Encargado INT,
	ID_Sucursal INT,
	Capacidad INT,
	FOREIGN KEY (ID_Encargado) REFERENCES Encargado(id),
	FOREIGN KEY (ID_Sucursal) REFERENCES Sucursal(id)
);

-- 8. Paquete
CREATE TABLE paquete (
	ID_GuiaMadre INT PRIMARY KEY,
	Pesokg FLOAT,
	LargoCM FLOAT,
	anchoCm FLOAT,
	altoCm FLOAT,
	descripcion VARCHAR(250),
	precio FLOAT,
	fragil VARCHAR(1),
	TiempoEntrega INT,
	ID_Bodega INT,
	ID_Sucursal INT,
	FOREIGN KEY (ID_Bodega) REFERENCES Bodega(ID_Bodega),
	FOREIGN KEY (ID_Sucursal) REFERENCES Sucursal(id)
);

-- 9. Pedido
CREATE TABLE pedido (
	ID INT PRIMARY KEY,
	ID_GUIA_M INT,
	ID_Cliente INT,
	estado VARCHAR(50),
	tipoPago INT,
	id_sucursal INT,
	fechaCreacion DATE,
	fechaSalida DATE,
	FOREIGN KEY (ID_GUIA_M) REFERENCES paquete(ID_GuiaMadre),
	FOREIGN KEY (ID_Cliente) REFERENCES clientes(ID_cliente),
	FOREIGN KEY (tipoPago) REFERENCES tipoPago(id),
	FOREIGN KEY (ID_Sucursal) REFERENCES Sucursal(id)
);

-- 10. Intermedias y movimientos
CREATE TABLE Paquete_Producto (
	id_PaqueteProducto INT PRIMARY KEY,
	ID_Producto INT,
	ID_Paquete INT,
	FOREIGN KEY (ID_Producto) REFERENCES producto(ID_producto),
	FOREIGN KEY (ID_Paquete) REFERENCES paquete(ID_GuiaMadre)
);

CREATE TABLE MovimientoBodega (
	ID INT PRIMARY KEY AUTO_INCREMENT,
	ID_Paquete INT,
	ID_Bodega INT,
	Ingreso DATE,
	salida DATE,
	ID_Sucursal INT,
	FOREIGN KEY (ID_Paquete) REFERENCES paquete(ID_GuiaMadre),
	FOREIGN KEY (ID_Bodega) REFERENCES Bodega(ID_Bodega),
	FOREIGN KEY (ID_Sucursal) REFERENCES Sucursal(id)
);

CREATE TABLE Tbl_AsignacionVehiculo (
	ID_AsignacionVehiculo INT PRIMARY KEY AUTO_INCREMENT,
	ID_Conductor INT,
	AsignacionVehiculo_Placa INT,
	AsignacionVehiculo_FchInicio DATE,
	AsignacionVehiculo_FchFinal DATE,
	FOREIGN KEY (ID_Conductor) REFERENCES conductores(id),
	FOREIGN KEY (AsignacionVehiculo_Placa) REFERENCES Vehiculos(iD_Placa)
);

-- IMPORTANTE: Se corrigen nombres mal referenciados
CREATE TABLE Tbl_AsignacionRutaConductor (
	ID_AsignacionRutaConductor INT PRIMARY KEY AUTO_INCREMENT,
	ID_Conductor INT,
	ID_ClienteDireccion INT,
	AsignacionRuta_FchAsignacion DATE,
	ID_TipoRuta INT,
	ID_Bodega INT,
	FOREIGN KEY (ID_Conductor) REFERENCES conductores(id),
	FOREIGN KEY (ID_ClienteDireccion) REFERENCES Tbl_ClienteDireccion(ID_ClienteDireccion),
	FOREIGN KEY (ID_TipoRuta) REFERENCES tipoRuta(ID_TipoRuta),
	FOREIGN KEY (ID_Bodega) REFERENCES Bodega(ID_Bodega)
);

CREATE TABLE rutaDetalle (
	ID INT PRIMARY KEY,
	ID_Ruta INT,
	ID_Pedido INT,
	FOREIGN KEY (ID_Ruta) REFERENCES Rutas(idRuta),
	FOREIGN KEY (ID_Pedido) REFERENCES pedido(ID)
);
