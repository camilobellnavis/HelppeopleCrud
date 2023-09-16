CREATE TABLE CIUDADANOS (
	ID INT IDENTITY (1, 1) PRIMARY KEY ,
	NOMBRES VARCHAR (255)  NULL ,
	APELLIDOS VARCHAR (255)  NULL ,
	FECHA_NACIMIENTO DATE  NULL ,
	PROFESION VARCHAR (60)  NULL ,
	ASPIRACION INT  NULL ,
	EMAIL VARCHAR (15)  NULL ,
	NUMERO_DOC VARCHAR (10)  NULL ,
	TIPO_DOC VARCHAR (15)  NULL ,
);


CREATE TABLE VACANTES (
	ID INT IDENTITY (1, 1) PRIMARY KEY ,
	CODIGO VARCHAR (255)  NULL ,
	CARGO VARCHAR (255)  NULL ,
	DESCRIPCION VARCHAR(255)  NULL ,
	EMPRESA VARCHAR (255)  NULL ,
	SALARIO INT  NULL,
	ESTADO BIT,
	ID_CIUDADANO INT FOREIGN KEY REFERENCES CIUDADANOS(ID)
);


--Scaffold-DbContext "Server=(localdb)\Servidor; DataBase=HPeople;Integrated Security=true" Microsoft.EntityFrameworkCore.SqlServer -OutPutDir DataContext


EXEC INSERT_VACANTES @Codigo='RS001',@Cargo='Ingeniero Industrial',@Descripcion='Se requiere Ingeniero Industrial  con mínimo 2 años de experiencia en Salud Ocupacional',@empresa='EPM',@salario=2500000,@estado=1,@id_ciudadano=NULL;
EXEC INSERT_VACANTES @Codigo='RS002',@Cargo='Profesor de Química',@Descripcion='Se requiere Quimico  con mínimo 3 años de experiencia en docencia',@empresa='INSTITUCION EDUCATIVA IES',@salario=1900000,@estado=1,@id_ciudadano=NULL;
EXEC INSERT_VACANTES @Codigo='RS003',@Cargo='Ingeniero de Desarrollo Junior',@Descripcion='Se requiere Ingeniero de Sistemas  con mínimo 1 año de experiencia en Desarrollo de Software en tecnologia JAVA',@empresa='XRM SERVICES',@salario=2600000,@estado=1,@id_ciudadano=NULL;
EXEC INSERT_VACANTES @Codigo='RS004',@Cargo='Coordinador de Mercadeo',@Descripcion='Se necesita Coordinador de Mercadeo con estudios tecnologicos graduado y experiencia minima de 1 año',@empresa='INSERCOL',@salario=1350000,@estado=1,@id_ciudadano=NULL;
EXEC INSERT_VACANTES @Codigo='RS005',@Cargo='Profesor de Matematicas',@Descripcion='Se requiere licenciado en matematicas o ingeniero con minimo dos años de experiencia en docencia',@empresa='SENA',@salario=1750000,@estado=1,@id_ciudadano=NULL;
EXEC INSERT_VACANTES @Codigo='RS006',@Cargo='Mensajero',@Descripcion='Se requiere con moto con documentos al dia y buenas relaciones personales',@empresa='SERVIENTREGA',@salario=950000,@estado=1,@id_ciudadano=NULL;
EXEC INSERT_VACANTES @Codigo='RS007',@Cargo='Cajero',@Descripcion='Se requiere Cajero para almacen de cadena con experiencia minima de un año debe disponer de tiempo por cambios de turnos',@empresa='ALMACENES EXITO',@salario=850000,@estado=1,@id_ciudadano=NULL;

