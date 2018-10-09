
--> Create tables:

	CREATE TABLE tbAcs (
		idAcs NUMERIC(4),
		nmAcs VARCHAR2(50),
		dcAcs VARCHAR2(255)
	);

	CREATE TABLE tbUsr (
		idUsr NUMERIC(9),
		lgUsr VARCHAR2(20),
		nmUsr VARCHAR2(50),
		pwUsr VARCHAR2(50),
		idAcs NUMERIC(4),
		dtnUsr DATE,
		dtaUsr DATE,
		cpfUsr VARCHAR2(20),
		endUsr VARCHAR2(255),
		sttUsr VARCHAR2(255),
		ctrUsr VARCHAR2(50)
	);

	CREATE TABLE tbPhn (
		idPhn NUMERIC(9),
		idUsr NUMERIC(9),
		tpPhn CHAR,
		ddPhn NUMERIC(2),
		nmPhn NUMERIC(9)
	);

	CREATE TABLE tbSrv (
		idSrv NUMERIC(4),
		nmSrv VARCHAR2(50),
		dcSrv VARCHAR2(255)
	);

	CREATE TABLE tbSts (
		idSts NUMERIC(4),
		nmSts VARCHAR2(50),
		dcSts VARCHAR2(255)
	);

	CREATE TABLE tbIds (
		idIds NUMERIC(9),
		idUsr NUMERIC(9),
		idSrv NUMERIC(4),
		dcIds VARCHAR2(255)
	);

	CREATE TABLE tbIdev (
		idIdev NUMERIC(9),
		idIds NUMERIC(9),
		idUsr NUMERIC(9),
		idSts NUMERIC(4),
		dtIdev DATE,
		acIds VARCHAR2(255)
	);

	CREATE TABLE tbLog (
		idLog NUMERIC(9),
		idUsr NUMERIC(9),
		dcLog VARCHAR2(255),
		dtLog DATE
	);


-->
	Commit;

--> Create primary keys:

	ALTER TABLE tbAcs
		ADD CONSTRAINT pk_idAcs
		PRIMARY KEY (idAcs);

	ALTER TABLE tbUsr
		ADD CONSTRAINT pk_idUsr
		PRIMARY KEY (idUsr);

	ALTER TABLE tbPhn
		ADD CONSTRAINT pk_idPhn
		PRIMARY KEY (idPhn);

	ALTER TABLE tbSrv
		ADD CONSTRAINT pk_idSrv
		PRIMARY KEY (idSrv);
	
	ALTER TABLE tbSts
		ADD CONSTRAINT pk_idSts
		PRIMARY KEY (idSts);

	ALTER TABLE tbIds
		ADD CONSTRAINT pk_idIds
		PRIMARY KEY (idIds);

	ALTER TABLE tbIdev
		ADD CONSTRAINT pk_idIdev
		PRIMARY KEY (idIdev);

	ALTER TABLE tbLog
		ADD CONSTRAINT pk_idLog
		PRIMARY KEY (idLog);


--> Create foreign Keys:

	ALTER TABLE tbUsr
		ADD CONSTRAINT fk_tbUsr_idAcs
		FOREIGN KEY (idAcs)
		REFERENCES tbAcs(idAcs);

	ALTER TABLE tbPhn
		ADD CONSTRAINT fk_tbPhn_idUsr
		FOREIGN KEY (idUsr)
		REFERENCES tbUsr(idUsr);

	ALTER TABLE tbLog
		ADD CONSTRAINT fk_tbLog_idUsr
		FOREIGN KEY (idUsr)
		REFERENCES tbUsr(idUsr);


	ALTER TABLE tbIds
		ADD CONSTRAINT fk_tbIds_idUsr
		FOREIGN KEY (idUsr)
		REFERENCES tbUsr(idUsr);

	ALTER TABLE tbIds
		ADD CONSTRAINT fk_tbIds_idSrv
		FOREIGN KEY (idSrv)
		REFERENCES tbSrv(idSrv);


	ALTER TABLE tbIdev
		ADD CONSTRAINT fk_tbIdev_idUsr
		FOREIGN KEY (idUsr)
		REFERENCES tbUsr(idUsr);
	
	ALTER TABLE tbIdev
		ADD CONSTRAINT fk_tbIdev_idSts
		FOREIGN KEY (idSts)
		REFERENCES tbSts(idSts);


-- Create unique:

	ALTER TABLE tbUsr
		ADD CONSTRAINT un_cpf
		UNIQUE (cpfUsr);

	ALTER TABLE tbUsr
		ADD CONSTRAINT un_login
		UNIQUE (lgUsr);

--> Auto Increment Constraint:

	CREATE SEQUENCE seq_Srv MINVALUE 1 START WITH 1 INCREMENT BY 1 CACHE 10;
	CREATE SEQUENCE seq_Sts MINVALUE 1 START WITH 1 INCREMENT BY 1 CACHE 10;
	CREATE SEQUENCE seq_Ids MINVALUE 1 START WITH 1 INCREMENT BY 1 CACHE 10;
	CREATE SEQUENCE seq_Idev MINVALUE 1 START WITH 1 INCREMENT BY 1 CACHE 10;
	
	CREATE SEQUENCE seq_Acs MINVALUE 1 START WITH 1 INCREMENT BY 10 CACHE 10;
	CREATE SEQUENCE seq_Phn MINVALUE 1 START WITH 1 INCREMENT BY 10 CACHE 10;
	CREATE SEQUENCE seq_Usr MINVALUE 10 START WITH 10 INCREMENT BY 10 CACHE 10;
	
	CREATE SEQUENCE seq_Log MINVALUE 1 START WITH 1 INCREMENT BY 1 CACHE 10;

-->
	Commit;

--> Insert dados:


/*---------------+ Tb Acessos +----------------*/
	INSERT INTO tbAcs(idAcs,nmAcs,dcAcs) VALUES(1,'padrao','Usuario padrao/cliente');
	INSERT INTO tbAcs(idAcs,nmAcs,dcAcs) VALUES(2,'adm','Usuario administrador do sistema');
	Commit;
/*---------------------------------------------*/

/*---------------+ Tb Servicos +---------------*/
	INSERT INTO tbSrv(idSrv,nmSrv,dcSrv) VALUES(1,'hardware','Pecas do computador e etc.');
	INSERT INTO tbSrv(idSrv,nmSrv,dcSrv) VALUES(2,'software','Sistema operacional, aplicativos e etc.');
	INSERT INTO tbSrv(idSrv,nmSrv,dcSrv) VALUES(3,'rede','Internet, Wifi, Roteador e etc.');
	INSERT INTO tbSrv(idSrv,nmSrv,dcSrv) VALUES(4,'perifericos','Mouse, teclado, monitor e etc.');
	INSERT INTO tbSrv(idSrv,nmSrv,dcSrv) VALUES(5,'outros','Outros servicos oferecidos por nos.');
	Commit;
/*---------------------------------------------*/

/*---------------+ Tb Usuarios +---------------*/
	INSERT INTO tbUsr(
		idUsr, --ID user
		lgUsr, --Login
		nmUsr, --Nome
		pwUsr, --Pass
		idAcs, --Acesso
		dtnUsr, --Data Nasc
		dtaUsr, --Data Reg
		cpfUsr, --CPF
		endUsr, --Endereco
		sttUsr, --Estado
		ctrUsr --Pais
	) VALUES (
		seq_Usr.nextval,
		'jsil140',
		'Jose Silva',
		123,
		2,
		'22-09-1994',
		(SELECT SYSDATE FROM DUAL),
		'11122233344', --CPF
		'Lago Azul, Fco Da Rocha',
		'SP',
		'BRAZIL'
	);

	INSERT INTO tbUsr(
		idUsr, --ID user
		lgUsr, --Login
		nmUsr, --Nome
		pwUsr, --Pass
		idAcs, --Acesso
		dtnUsr, --Data Nasc
		dtaUsr, --Data Reg
		cpfUsr, --CPF
		endUsr, --Endereco
		sttUsr, --Estado
		ctrUsr --Pais
	) VALUES (
		seq_Usr.nextval,
		'joseph', --Login
		'Jose Silva', --Nome
		123, --Pass
		1, --Acesso
		'22-09-1994', --Data Nasc
		(SELECT SYSDATE FROM DUAL), --Data Reg
		'22233344455', --CPF
		'Lago Azul, Fco Da Rocha', --Endereco
		'SP', --Estado
		'BRAZIL' --Pais
	);
	Commit;
/*---------------------------------------------*/

--> Functions:

CREATE FUNCTION AGORA
   RETURN VARCHAR2
   IS resp VARCHAR2(20);
	BEGIN
	    SELECT TO_CHAR(SYSDATE, 'DD/MM/YYYY HH24:MI:SS') INTO resp FROM DUAL;
	    RETURN(resp);
	END;

	Commit;


--> Procedures:

CREATE OR REPLACE PROCEDURE cons_user(
    varLgUsr IN VARCHAR2, --Login
    varIdUsr OUT NUMERIC, --ID user
    varNmUsr OUT VARCHAR2, --Nome
    varPwUsr OUT VARCHAR2, --Pass
    vaIdAcs OUT NUMERIC, --Acesso
    varDtnUsr OUT DATE, --Data Nasc
    varDtaUsr OUT DATE, --Data Reg
    varCpfUsr OUT VARCHAR2, --CPF
    varEndUsr OUT VARCHAR2, --Endereco
    varSttUsr OUT VARCHAR2, --Estado
    varCtrUsr OUT VARCHAR2, --Pais
    varVerif OUT NUMERIC
) IS
    BEGIN
        SELECT 
            idUsr, --ID user
            nmUsr, --Nome
            pwUsr, --Pass
            idAcs, --Acesso
            dtnUsr, --Data Nasc
            dtaUsr, --Data Reg
            cpfUsr, --CPF
            endUsr, --Endereco
            sttUsr, --Estado
            ctrUsr --Pais
        INTO
            varIdUsr, --ID user
            varNmUsr, --Nome
            varPwUsr, --Pass
            vaIdAcs, --Acesso
            varDtnUsr, --Data Nasc
            varDtaUsr, --Data Reg
            varCpfUsr, --CPF
            varEndUsr, --Endereco
            varSttUsr, --Estado
            varCtrUsr --Pais
        FROM tbUsr
        WHERE lgUsr = varLgUsr;
        
        varVerif := 1;
        
    EXCEPTION
        WHEN NO_DATA_FOUND THEN
            varVerif := 0;
                
    END cons_user;


--> Teste de procedures
DECLARE
    varLgUsr tbUsr.lgUsr%TYPE; --Login
    varIdUsr tbUsr.IdUsr%TYPE; --ID user
    varNmUsr tbUsr.nmUsr%TYPE; --Nome
    varPwUsr tbUsr.pwUsr%TYPE; --Pass
    vaIdAcs tbUsr.idAcs%TYPE; --Acesso
    varDtnUsr tbUsr.dtnUsr%TYPE; --Data Nasc
    varDtaUsr tbUsr.dtaUsr%TYPE; --Data Reg
    varCpfUsr tbUsr.cpfUsr%TYPE; --CPF
    varEndUsr tbUsr.endUsr%TYPE; --Endereco
    varSttUsr tbUsr.sttUsr%TYPE; --Estado
    varCtrUsr tbUsr.ctrUsr%TYPE; --Pais
    varVerif NUMERIC(1); --Verificação 
BEGIN
    cons_user(
            'jsil140', --Login
            varIdUsr, --ID user
            varNmUsr, --Nome
            varPwUsr, --Pass
            vaIdAcs, --Acesso
            varDtnUsr, --Data Nasc
            varDtaUsr, --Data Reg
            varCpfUsr, --CPF
            varEndUsr, --Endereco
            varSttUsr, --Estado
            varCtrUsr, --Pais
            varVerif --Verificação
    );
    DBMS_OUTPUT.PUT_LINE('Nome: '||varNmUsr);
END;