-- ------------ Write DROP-FOREIGN-KEY-CONSTRAINT-stage scripts -----------

/* Note: Uncomment this section of DROP CONSTRAINTS IF YOU ARE RE-EXECUTING THIS File


ALTER TABLE customfieldmapping DROP CONSTRAINT IF EXISTS fk_customfieldmapping_id_taxappyear;


ALTER TABLE customfieldvalues DROP CONSTRAINT IF EXISTS fk_customfieldvalues_id_customfieldmapping;


ALTER TABLE customfieldvalues DROP CONSTRAINT IF EXISTS fk_customfieldvalues_id_rule;


ALTER TABLE diagnosticsviewerrulestate DROP CONSTRAINT IF EXISTS fk_diagnosticsviewerrulestate_locator;


ALTER TABLE diagnosticsviewerrulestate DROP CONSTRAINT IF EXISTS fk_diagnosticsviewerrulestate_rule;


ALTER TABLE field DROP CONSTRAINT IF EXISTS fk_field_id_jurisdiction;


ALTER TABLE field DROP CONSTRAINT IF EXISTS fk_field_id_returntype;


ALTER TABLE field DROP CONSTRAINT IF EXISTS fk_field_id_schematype;


ALTER TABLE fieldtotaxappyear DROP CONSTRAINT IF EXISTS fk_fieldtotaxappyear_rule;


ALTER TABLE fieldtotaxappyear DROP CONSTRAINT IF EXISTS fk_fieldtotaxappyear_taxappyear;


ALTER TABLE gotolink DROP CONSTRAINT IF EXISTS fk_ruleid_gotolink;


ALTER TABLE jurisdiction DROP CONSTRAINT IF EXISTS fk_jurisdiction_id_country;


ALTER TABLE jurisdiction DROP CONSTRAINT IF EXISTS fk_jurisdiction_id_jurisdictiontype;


ALTER TABLE metadataversion DROP CONSTRAINT IF EXISTS fk_metadataversion_id_jurisdiction;


ALTER TABLE metadataversion DROP CONSTRAINT IF EXISTS fk_metadataversion_id_returntype;


ALTER TABLE metadataversion DROP CONSTRAINT IF EXISTS fk_metadataversion_id_schematype;


ALTER TABLE metadataversion DROP CONSTRAINT IF EXISTS fk_metadataversion_id_taxappyear;


ALTER TABLE purgerulegotolink DROP CONSTRAINT IF EXISTS fk_ruleid_purgerulegotolink;


ALTER TABLE purgeruletocategory DROP CONSTRAINT IF EXISTS fk_purgeruletocategoryid_category;


ALTER TABLE purgeruletocategory DROP CONSTRAINT IF EXISTS fk_purgeruletocategoryid_rule;


ALTER TABLE purgeruletosecondaryjurisdiction DROP CONSTRAINT IF EXISTS fk_purgeruletosecondaryjurisdiction_jurisdiction;


ALTER TABLE purgeruletosecondaryjurisdiction DROP CONSTRAINT IF EXISTS fk_purgeruletosecondaryjurisdiction_rule;


ALTER TABLE purgeruletosecondaryreturntype DROP CONSTRAINT IF EXISTS fk_purgeruletosecondaryreturntype_returntype;


ALTER TABLE purgeruletosecondaryreturntype DROP CONSTRAINT IF EXISTS fk_purgeruletosecondaryreturntypeid_rule;


ALTER TABLE returntypetojurisdiction DROP CONSTRAINT IF EXISTS fk_returntypetojurisdictio_jurisdiction;


ALTER TABLE returntypetojurisdiction DROP CONSTRAINT IF EXISTS fk_returntypetojurisdiction_returntype;


ALTER TABLE rule DROP CONSTRAINT IF EXISTS fk_rule_id_jurisdiction;


ALTER TABLE rule DROP CONSTRAINT IF EXISTS fk_rule_id_returntype;


ALTER TABLE rule DROP CONSTRAINT IF EXISTS fk_rule_id_schematype;


ALTER TABLE rule DROP CONSTRAINT IF EXISTS fk_rule_id_taxappyear;


ALTER TABLE rule DROP CONSTRAINT IF EXISTS fk_rule_id_taxprofilearea;


ALTER TABLE ruleexecutionlog DROP CONSTRAINT IF EXISTS fk_evaluationrequestid;


ALTER TABLE ruleexecutionlog DROP CONSTRAINT IF EXISTS fk_ruleexecutionlog_id_locator;


ALTER TABLE ruleexecutionlog DROP CONSTRAINT IF EXISTS fk_ruleexecutionlog_schematype;


ALTER TABLE ruleexpression DROP CONSTRAINT IF EXISTS fk_ruleexpression_id_jurisdiction;


ALTER TABLE ruleexpression DROP CONSTRAINT IF EXISTS fk_ruleexpression_id_returntype;


ALTER TABLE ruleexpression DROP CONSTRAINT IF EXISTS fk_ruleexpression_id_taxappyear;


ALTER TABLE ruleheader DROP CONSTRAINT IF EXISTS fk_ruleheader_id_fileformat;


ALTER TABLE ruleheader DROP CONSTRAINT IF EXISTS fk_ruleheader_id_jurisdiction;


ALTER TABLE ruleheader DROP CONSTRAINT IF EXISTS fk_ruleheader_id_returntype;


ALTER TABLE ruleheader DROP CONSTRAINT IF EXISTS fk_ruleheader_id_taxappyear;


ALTER TABLE rulehistory DROP CONSTRAINT IF EXISTS fk_rulehistory_rule_id;


ALTER TABLE ruletocategory DROP CONSTRAINT IF EXISTS fk_ruletocategoryid_category;


ALTER TABLE ruletocategory DROP CONSTRAINT IF EXISTS fk_ruletocategoryid_rule;


ALTER TABLE ruletofield DROP CONSTRAINT IF EXISTS fk_ruletofieldid_field;


ALTER TABLE ruletofield DROP CONSTRAINT IF EXISTS fk_ruletofieldid_rule;


ALTER TABLE ruletosecondaryjurisdiction DROP CONSTRAINT IF EXISTS fk_ruletosecondaryjurisdiction_jurisdiction;


ALTER TABLE ruletosecondaryjurisdiction DROP CONSTRAINT IF EXISTS fk_ruletosecondaryjurisdiction_rule;


ALTER TABLE ruletosecondaryreturntype DROP CONSTRAINT IF EXISTS fk_ruletosecondaryreturntype_returntype;


ALTER TABLE ruletosecondaryreturntype DROP CONSTRAINT IF EXISTS fk_ruletosecondaryreturntypeid_rule;


-- ------------ Write DROP-CONSTRAINT-stage scripts -----------

ALTER TABLE category DROP CONSTRAINT IF EXISTS pk_category_id;



ALTER TABLE country DROP CONSTRAINT IF EXISTS pk_country_id;



ALTER TABLE customfieldmapping DROP CONSTRAINT IF EXISTS pk_customfieldmapping_id;



ALTER TABLE customfieldvalues DROP CONSTRAINT IF EXISTS pk_mappingelement_id;



ALTER TABLE diagnosticsviewerrulestate DROP CONSTRAINT IF EXISTS pk_diagnosticsviewerrulestate_id;



ALTER TABLE evaluationrequest DROP CONSTRAINT IF EXISTS pk_evaluationrequest_id;



ALTER TABLE field DROP CONSTRAINT IF EXISTS pk_field_id;



ALTER TABLE fieldtotaxappyear DROP CONSTRAINT IF EXISTS pk_fieldtotaxappyear;



ALTER TABLE fileformat DROP CONSTRAINT IF EXISTS pk_fileformat_id;



ALTER TABLE gotolink DROP CONSTRAINT IF EXISTS pk_gotolink_id;



ALTER TABLE jurisdiction DROP CONSTRAINT IF EXISTS pk_jurisdiction_id;



ALTER TABLE jurisdictiontype DROP CONSTRAINT IF EXISTS pk_jurisdictiontype_id;



ALTER TABLE locator DROP CONSTRAINT IF EXISTS pk_locator_id;



ALTER TABLE metadatafield DROP CONSTRAINT IF EXISTS pk_metadatafield_s_no;



ALTER TABLE metadataversion DROP CONSTRAINT IF EXISTS pk_metadataversion_id;



ALTER TABLE printdiagnostic DROP CONSTRAINT IF EXISTS pk_printdiagnostic;



ALTER TABLE purgerule DROP CONSTRAINT IF EXISTS pk_purgerule_id;



ALTER TABLE purgerulegotolink DROP CONSTRAINT IF EXISTS pk_purgerulegotolink_id;



ALTER TABLE purgeruletocategory DROP CONSTRAINT IF EXISTS pk_purgeruletocategoryid;



ALTER TABLE purgeruletosecondaryjurisdiction DROP CONSTRAINT IF EXISTS pk_purgeruletojurisdictionid;



ALTER TABLE purgeruletosecondaryreturntype DROP CONSTRAINT IF EXISTS pk_purgeruletoreturntypeid;



ALTER TABLE returntype DROP CONSTRAINT IF EXISTS pk_returntype_id;



ALTER TABLE returntypetojurisdiction DROP CONSTRAINT IF EXISTS pk_returntypetojurisdictionid;



ALTER TABLE rule DROP CONSTRAINT IF EXISTS pk_rule_id;



ALTER TABLE ruleexecutionlog DROP CONSTRAINT IF EXISTS pk_ruleexecutionlog_id;



ALTER TABLE ruleexpression DROP CONSTRAINT IF EXISTS pk_ruleexpression_id;



ALTER TABLE ruleheader DROP CONSTRAINT IF EXISTS pk_ruleheader_id;



ALTER TABLE rulehistory DROP CONSTRAINT IF EXISTS pk_rulehistory_id;



ALTER TABLE ruleserviceinstance DROP CONSTRAINT IF EXISTS pk_ruleserviceinstance_id;



ALTER TABLE ruletocategory DROP CONSTRAINT IF EXISTS pk_ruletocategoryid;



ALTER TABLE ruletofield DROP CONSTRAINT IF EXISTS pk_ruletofiid;



ALTER TABLE ruletosecondaryjurisdiction DROP CONSTRAINT IF EXISTS pk_ruletosecondaryjurisdictionid;



ALTER TABLE ruletosecondaryreturntype DROP CONSTRAINT IF EXISTS pk_ruletosecondaryreturntypeid;



ALTER TABLE schemastructurerulemapping DROP CONSTRAINT IF EXISTS pk_schemastructurerulemapping_id;



ALTER TABLE schematype DROP CONSTRAINT IF EXISTS pk_schematype_id;



ALTER TABLE serviceconfiguration DROP CONSTRAINT IF EXISTS pk__serviceid;



ALTER TABLE taxappyear DROP CONSTRAINT IF EXISTS pk_taxappyear_id;



ALTER TABLE taxprofilearea DROP CONSTRAINT IF EXISTS pk_taxprofilearea_id;



ALTER TABLE userpreference DROP CONSTRAINT IF EXISTS pk_userpreference_userid;


*/
-- ------------ Write DROP-INDEX-stage scripts -----------

DROP INDEX IF EXISTS ix_evaluationrequest_ncidx_evaluation_requeststatus_instancenam;



DROP INDEX IF EXISTS ix_field_ncidx_field_returntypeid_jurisdictionid_schematypeid;



DROP INDEX IF EXISTS ix_field_ncidx_field_xpath;



DROP INDEX IF EXISTS ix_locator_ncidx_locator_returntype_taxappyear_jurisdiction_nam;



DROP INDEX IF EXISTS ix_rule_ncidx_rule_returntypeid_taxappyearid_jurisdictionid_sch;



DROP INDEX IF EXISTS ix_versioninfo_uc_version;



-- ------------ Write DROP-TABLE-stage scripts -----------

DROP TABLE IF EXISTS category;



DROP TABLE IF EXISTS country;



DROP TABLE IF EXISTS customfieldmapping;



DROP TABLE IF EXISTS customfieldvalues;



DROP TABLE IF EXISTS diagnosticsviewerrulestate;



DROP TABLE IF EXISTS evaluationrequest;



DROP TABLE IF EXISTS field;



DROP TABLE IF EXISTS field_duplicate;



DROP TABLE IF EXISTS fieldtotaxappyear;



DROP TABLE IF EXISTS fileformat;



DROP TABLE IF EXISTS gotolink;



DROP TABLE IF EXISTS jurisdiction;



DROP TABLE IF EXISTS jurisdictiontype;



DROP TABLE IF EXISTS locator;



DROP TABLE IF EXISTS metadatafield;



DROP TABLE IF EXISTS metadataversion;



DROP TABLE IF EXISTS printdiagnostic;



DROP TABLE IF EXISTS purgefield;



DROP TABLE IF EXISTS purgerule;



DROP TABLE IF EXISTS purgerulegotolink;



DROP TABLE IF EXISTS purgeruletocategory;



DROP TABLE IF EXISTS purgeruletosecondaryjurisdiction;



DROP TABLE IF EXISTS purgeruletosecondaryreturntype;



DROP TABLE IF EXISTS returntype;



DROP TABLE IF EXISTS returntypetojurisdiction;



DROP TABLE IF EXISTS rule;



DROP TABLE IF EXISTS rule_field_duplicate;



DROP TABLE IF EXISTS ruleexecutionlog;



DROP TABLE IF EXISTS ruleexpression;



DROP TABLE IF EXISTS ruleheader;



DROP TABLE IF EXISTS rulehistory;



DROP TABLE IF EXISTS ruleserviceinstance;



DROP TABLE IF EXISTS ruletocategory;



DROP TABLE IF EXISTS ruletofield;



DROP TABLE IF EXISTS ruletosecondaryjurisdiction;



DROP TABLE IF EXISTS ruletosecondaryreturntype;



DROP TABLE IF EXISTS schemastructurerulemapping;



DROP TABLE IF EXISTS schematype;



DROP TABLE IF EXISTS serviceconfiguration;



DROP TABLE IF EXISTS taxappyear;



DROP TABLE IF EXISTS taxprofilearea;



DROP TABLE IF EXISTS temprulestoupdate;



DROP TABLE IF EXISTS userpreference;



DROP TABLE IF EXISTS versioninfo;

--------Create Tables Script-------

CREATE EXTENSION IF NOT EXISTS "uuid-ossp";

-- ------------ Write CREATE-TABLE-stage scripts -----------

CREATE TABLE category(
    id UUID NOT NULL DEFAULT uuid_generate_v4(),
    name VARCHAR(255) NOT NULL
)
        WITH (
        OIDS=FALSE
        );



CREATE TABLE country(
    id UUID NOT NULL DEFAULT uuid_generate_v4(),
    name VARCHAR(255) NOT NULL
)
        WITH (
        OIDS=FALSE
        );



CREATE TABLE customfieldmapping(
    id UUID NOT NULL DEFAULT uuid_generate_v4(),
    returntypeid UUID NOT NULL,
    taxappyearid UUID NOT NULL,
    jurisdictionid UUID NOT NULL,
    fieldname VARCHAR(255),
    mappingfield VARCHAR(255)
)
        WITH (
        OIDS=FALSE
        );



CREATE TABLE customfieldvalues(
    ruleid UUID,
    value TEXT,
    id UUID NOT NULL,
    customfieldmappingid UUID NOT NULL
)
        WITH (
        OIDS=FALSE
        );



CREATE TABLE diagnosticsviewerrulestate(
    id UUID NOT NULL DEFAULT uuid_generate_v4(),
    ruleid UUID NOT NULL,
    locatorid UUID NOT NULL,
    hidden  boolean NOT NULL DEFAULT False,--NUMERIC(1,0)
    evaluationid NUMERIC(10,0) NOT NULL DEFAULT (1)
)
        WITH (
        OIDS=FALSE
        );



CREATE TABLE evaluationrequest(
    id BIGINT NOT NULL GENERATED ALWAYS AS IDENTITY,
    taxappyear VARCHAR(255) NOT NULL,
    returntype VARCHAR(255) NOT NULL,
    jurisdiction VARCHAR(255) NOT NULL,
    locator VARCHAR(255) NOT NULL,
    schematype VARCHAR(255) NOT NULL,
    documenttoevaluate TEXT NOT NULL,
    requeststatus VARCHAR(255) NOT NULL,
    dateofcreation TIMESTAMP WITHOUT TIME ZONE NOT NULL DEFAULT localtimestamp(6),
    datemodified TIMESTAMP WITHOUT TIME ZONE NOT NULL DEFAULT localtimestamp(6),
    instancename VARCHAR(255),
    requestedby VARCHAR(255),
    filesize NUMERIC(20,0) NOT NULL DEFAULT (0)
)
        WITH (
        OIDS=FALSE
        );



CREATE TABLE field(
    id NUMERIC(10,0) NOT NULL,
    area NUMERIC(10,0),
    screen NUMERIC(10,0),
    field NUMERIC(10,0),
    typedesc VARCHAR(128),
    eorg TEXT,
    name TEXT,
    annotation TEXT,
    returntypeid UUID NOT NULL,
    xpath VARCHAR(900),
    jurisdictionid UUID,
    iselement  boolean NOT NULL DEFAULT True,--NUMERIC(1,0)
    schematypeid UUID NOT NULL DEFAULT 'FD31E9F4-B324-E511-90A8-A41731006EEE',
    minoccurs VARCHAR(10),
    maxoccurs VARCHAR(10),
    issimpletype boolean,--NUMERIC(1,0)
    formname VARCHAR(255),
    datemodified TIMESTAMP WITHOUT TIME ZONE DEFAULT '2016-01-01 00:00:00.000'
)
        WITH (
        OIDS=FALSE
        );



CREATE TABLE field_duplicate(
    id NUMERIC(10,0) NOT NULL
)
        WITH (
        OIDS=FALSE
        );



CREATE TABLE fieldtotaxappyear(
    fieldid NUMERIC(10,0) NOT NULL,
    taxappyearid UUID NOT NULL
)
        WITH (
        OIDS=FALSE
        );



CREATE TABLE fileformat(
    id UUID NOT NULL DEFAULT uuid_generate_v4(),
    formattype VARCHAR(255) NOT NULL
)
        WITH (
        OIDS=FALSE
        );



CREATE TABLE gotolink(
    id UUID NOT NULL DEFAULT uuid_generate_v4(),
    ruleid UUID NOT NULL,
    area VARCHAR(255),
    screen VARCHAR(255),
    field VARCHAR(255)
)
        WITH (
        OIDS=FALSE
        );



CREATE TABLE jurisdiction(
    id UUID NOT NULL DEFAULT uuid_generate_v4(),
    name VARCHAR(255),
    countryid UUID,
    shortname VARCHAR(255),
    jurisdictiontypeid NUMERIC(10,0) NOT NULL DEFAULT (2)
)
        WITH (
        OIDS=FALSE
        );



CREATE TABLE jurisdictiontype(
    id NUMERIC(10,0) NOT NULL,
    name VARCHAR(255)
)
        WITH (
        OIDS=FALSE
        );



CREATE TABLE locator(
    id UUID NOT NULL,
    returntype VARCHAR(100) NOT NULL,
    taxappyear VARCHAR(20) NOT NULL,
    name VARCHAR(100) NOT NULL,
    jurisdiction VARCHAR(200) NOT NULL
)
        WITH (
        OIDS=FALSE
        );



CREATE TABLE metadatafield(
    id NUMERIC(10,0) NOT NULL,
    s_no BIGINT NOT NULL GENERATED ALWAYS AS IDENTITY,
    taxapplication VARCHAR(4) NOT NULL,
    year NUMERIC(10,0) NOT NULL,
    description VARCHAR(255),
    returntype VARCHAR(255),
    jurisdiction VARCHAR(255),
    type TEXT NOT NULL,
    name TEXT NOT NULL,
    xpath TEXT NOT NULL,
    is_element NUMERIC(10,0) NOT NULL,
    annotation TEXT,
    min_occurs TEXT,
    max_occurs TEXT,
    is_simpletype NUMERIC(5,0),
    returntypeid UUID,
    taxappyearid UUID,
    jurisdictionid UUID,
    formname TEXT
)
        WITH (
        OIDS=FALSE
        );



CREATE TABLE metadataversion(
    fileinfoid NUMERIC(10,0) NOT NULL,
    taxappyearid UUID NOT NULL,
    returntypeid UUID NOT NULL,
    jurisdictionid UUID NOT NULL,
    schematypeid UUID NOT NULL,
    datemodified TIMESTAMP WITHOUT TIME ZONE NOT NULL DEFAULT localtimestamp(6),
    id UUID NOT NULL DEFAULT uuid_generate_v4()
)
        WITH (
        OIDS=FALSE
        );



CREATE TABLE printdiagnostic(
    id UUID NOT NULL,
    starttime TIMESTAMP WITHOUT TIME ZONE,
    endtime TIMESTAMP WITHOUT TIME ZONE,
    status VARCHAR(20),
    fileurl VARCHAR(255),
    locator VARCHAR(255),
    taxappyear VARCHAR(255),
    returntype VARCHAR(255),
    filter TEXT
)
        WITH (
        OIDS=FALSE
        );



CREATE TABLE purgefield(
    id NUMERIC(10,0) NOT NULL,
    area NUMERIC(10,0),
    screen NUMERIC(10,0),
    field NUMERIC(10,0),
    typedesc VARCHAR(128),
    eorg TEXT,
    name TEXT,
    annotation TEXT,
    returntypeid UUID NOT NULL,
    xpath VARCHAR(900),
    jurisdictionid UUID,
    iselement boolean  NOT NULL,--NUMERIC(1,0)
    schematypeid UUID NOT NULL,
    minoccurs VARCHAR(10),
    maxoccurs VARCHAR(10),
    issimpletype boolean,--NUMERIC(1,0)
    formname VARCHAR(255),
    datemodified TIMESTAMP WITHOUT TIME ZONE
)
        WITH (
        OIDS=FALSE
        );



CREATE TABLE purgerule(
    id UUID NOT NULL,
    rulenumber VARCHAR(500) NOT NULL,
    returntypeid UUID NOT NULL,
    jurisdictionid UUID NOT NULL,
    taxappyearid UUID NOT NULL,
    ruletext TEXT NOT NULL,
    jurisdictionstatus VARCHAR(255),
    modifiedby VARCHAR(255),
    datemodified TIMESTAMP WITHOUT TIME ZONE,
    isdeleted  boolean NOT NULL DEFAULT False,--NUMERIC(1,0)
    isactive boolean NOT NULL DEFAULT True,--NUMERIC(1,0)
    severity VARCHAR(225),
    logic VARCHAR(4000),
    ispublished boolean NOT NULL DEFAULT False,--NUMERIC(1,0)
    alternatetext TEXT,
    schematypeid UUID,
    linkedquery TEXT,
    taxprofileareaid UUID,
    xquery TEXT,
    useatleast NUMERIC(10,0),
    placeholderfields VARCHAR(1000),
    precision NUMERIC(10,0),
    status VARCHAR(100)
)
        WITH (
        OIDS=FALSE
        );



CREATE TABLE purgerulegotolink(
    id UUID NOT NULL DEFAULT uuid_generate_v4(),
    ruleid UUID NOT NULL,
    area VARCHAR(255),
    screen VARCHAR(255),
    field VARCHAR(255)
)
        WITH (
        OIDS=FALSE
        );



CREATE TABLE purgeruletocategory(
    purgeruleid UUID NOT NULL,
    categoryid UUID NOT NULL
)
        WITH (
        OIDS=FALSE
        );



CREATE TABLE purgeruletosecondaryjurisdiction(
    ruleid UUID NOT NULL,
    jurisdictionid UUID NOT NULL
)
        WITH (
        OIDS=FALSE
        );



CREATE TABLE purgeruletosecondaryreturntype(
    ruleid UUID NOT NULL,
    returntypeid UUID NOT NULL
)
        WITH (
        OIDS=FALSE
        );



CREATE TABLE returntype(
    id UUID NOT NULL DEFAULT uuid_generate_v4(),
    name VARCHAR(255) NOT NULL
)
        WITH (
        OIDS=FALSE
        );



CREATE TABLE returntypetojurisdiction(
    returntypeid UUID NOT NULL,
    jurisdictionid UUID NOT NULL
)
        WITH (
        OIDS=FALSE
        );



CREATE TABLE rule(
    id UUID NOT NULL,
    rulenumber VARCHAR(500) NOT NULL,
    returntypeid UUID NOT NULL,
    jurisdictionid UUID NOT NULL,
    taxappyearid UUID NOT NULL,
    ruletext TEXT NOT NULL,
    jurisdictionstatus VARCHAR(255),
    modifiedby VARCHAR(255),
    datemodified TIMESTAMP WITHOUT TIME ZONE,
    isdeleted boolean NOT NULL DEFAULT False,--NUMERIC(1,0)
    isactive boolean NOT NULL DEFAULT True,--NUMERIC(1,0)
    severity VARCHAR(225),
    logic TEXT,
    ispublished boolean NOT NULL DEFAULT False,--NUMERIC(1,0)
    alternatetext TEXT,
    schematypeid UUID NOT NULL DEFAULT 'FD31E9F4-B324-E511-90A8-A41731006EEE',
    linkedquery TEXT,
    taxprofileareaid UUID,
    xquery TEXT,
    useatleast NUMERIC(10,0),
    placeholderfields VARCHAR(1000),
    precision NUMERIC(10,0),
    status VARCHAR(100)
)
        WITH (
        OIDS=FALSE
        );



CREATE TABLE rule_field_duplicate(
    id UUID NOT NULL
)
        WITH (
        OIDS=FALSE
        );



CREATE TABLE ruleexecutionlog(
    id UUID NOT NULL,
    locatorid UUID NOT NULL,
    starttime TIMESTAMP WITHOUT TIME ZONE NOT NULL,
    endtime TIMESTAMP WITHOUT TIME ZONE,
    status VARCHAR(255),
    diagnosticinfo TEXT,
    schematypeid UUID NOT NULL DEFAULT 'FD31E9F4-B324-E511-90A8-A41731006EEE',
    evaluationrequestid BIGINT NOT NULL DEFAULT NULL
)
        WITH (
        OIDS=FALSE
        );



CREATE TABLE ruleexpression(
    id UUID NOT NULL DEFAULT uuid_generate_v4(),
    rulenumber VARCHAR(500) NOT NULL,
    jurisdictionid UUID NOT NULL,
    returntypeid UUID,
    taxappyearid UUID,
    expression TEXT,
    modifiedby VARCHAR(255),
    datemodified TIMESTAMP WITHOUT TIME ZONE
)
        WITH (
        OIDS=FALSE
        );



CREATE TABLE ruleheader(
    id UUID NOT NULL DEFAULT uuid_generate_v4(),
    returntypeid UUID NOT NULL,
    taxappyearid UUID NOT NULL,
    jurisdictionid UUID NOT NULL,
    rulenumber VARCHAR(50),
    ruletext VARCHAR(50),
    severity VARCHAR(50),
    jurisdictionstatus VARCHAR(50),
    fileformatid UUID
)
        WITH (
        OIDS=FALSE
        );



CREATE TABLE rulehistory(
    id UUID NOT NULL DEFAULT uuid_generate_v4(),
    datemodified TIMESTAMP WITHOUT TIME ZONE,
    modifiedby VARCHAR(255),
    ruleid UUID,
    actionmessage VARCHAR(225)
)
        WITH (
        OIDS=FALSE
        );



CREATE TABLE ruleserviceinstance(
    id UUID NOT NULL DEFAULT uuid_generate_v4(),
    instancename VARCHAR(255),
    active boolean,--NUMERIC(1,0)
    queuesize NUMERIC(10,0)
)
        WITH (
        OIDS=FALSE
        );



CREATE TABLE ruletocategory(
    ruleid UUID NOT NULL,
    categoryid UUID NOT NULL
)
        WITH (
        OIDS=FALSE
        );



CREATE TABLE ruletofield(
    ruleid UUID NOT NULL,
    fieldid NUMERIC(10,0) NOT NULL
)
        WITH (
        OIDS=FALSE
        );



CREATE TABLE ruletosecondaryjurisdiction(
    ruleid UUID NOT NULL,
    jurisdictionid UUID NOT NULL
)
        WITH (
        OIDS=FALSE
        );



CREATE TABLE ruletosecondaryreturntype(
    ruleid UUID NOT NULL,
    returntypeid UUID NOT NULL
)
        WITH (
        OIDS=FALSE
        );



CREATE TABLE schemastructurerulemapping(
    id UUID NOT NULL DEFAULT uuid_generate_v4(),
    returntype VARCHAR(255) NOT NULL,
    schemastructureset VARCHAR(255) NOT NULL,
    rulesinvolved TEXT NOT NULL
)
        WITH (
        OIDS=FALSE
        );



CREATE TABLE schematype(
    id UUID NOT NULL DEFAULT uuid_generate_v4(),
    name VARCHAR(255) NOT NULL
)
        WITH (
        OIDS=FALSE
        );



CREATE TABLE serviceconfiguration(
    id BIGINT NOT NULL GENERATED ALWAYS AS IDENTITY,
    maintenancemode boolean --NUMERIC(1,0)
)
        WITH (
        OIDS=FALSE
        );



CREATE TABLE taxappyear(
    id UUID NOT NULL DEFAULT uuid_generate_v4(),
    year VARCHAR(255) NOT NULL
)
        WITH (
        OIDS=FALSE
        );



CREATE TABLE taxprofilearea(
    id UUID NOT NULL DEFAULT uuid_generate_v4(),
    name VARCHAR(255) NOT NULL
)
        WITH (
        OIDS=FALSE
        );



CREATE TABLE temprulestoupdate(
    ruleid UUID NOT NULL,
    oldfieldid NUMERIC(10,0) NOT NULL,
    newfieldid NUMERIC(10,0) NOT NULL
)
        WITH (
        OIDS=FALSE
        );



CREATE TABLE userpreference(
    userid VARCHAR(20) NOT NULL,
    preferencejson VARCHAR(2000)
)
        WITH (
        OIDS=FALSE
        );



CREATE TABLE versioninfo(
    version NUMERIC(20,0) NOT NULL,
    appliedon TIMESTAMP WITHOUT TIME ZONE,
    description VARCHAR(1024)
)
        WITH (
        OIDS=FALSE
        );


-- ------------ Write CREATE-INDEX-stage scripts -----------

CREATE INDEX ix_evaluationrequest_ncidx_evaluation_requeststatus_instancename
ON evaluationrequest
USING BTREE (requeststatus ASC,instancename, filesize); --INCLUDE(instancename, filesize);



CREATE INDEX ix_field_ncidx_field_returntypeid_jurisdictionid_schematypeid
ON field
USING BTREE (returntypeid ASC, jurisdictionid ASC, schematypeid ASC,id, area, screen, field, typedesc, eorg, name, annotation, xpath, iselement, formname); -- INCLUDE(id, area, screen, field, typedesc, eorg, name, annotation, xpath, iselement, formname);



CREATE INDEX ix_field_ncidx_field_xpath
ON field
USING BTREE (xpath ASC,maxoccurs, issimpletype); -- INCLUDE(maxoccurs, issimpletype);



CREATE INDEX ix_locator_ncidx_locator_returntype_taxappyear_jurisdiction_name
ON locator
USING BTREE (id,returntype ASC, taxappyear ASC, jurisdiction ASC, name ASC);-- INCLUDE(id);



CREATE INDEX ix_rule_ncidx_rule_returntypeid_taxappyearid_jurisdictionid_schematypeid
ON rule
USING BTREE (id, rulenumber, ruletext, jurisdictionstatus, modifiedby, datemodified, isdeleted, isactive, severity, logic, ispublished, alternatetext,returntypeid ASC, taxappyearid ASC, jurisdictionid ASC, schematypeid ASC);-- INCLUDE(id, rulenumber, ruletext, jurisdictionstatus, modifiedby, datemodified, isdeleted, isactive, severity, logic, ispublished, alternatetext);



CREATE UNIQUE INDEX ix_versioninfo_uc_version
ON versioninfo
USING BTREE (version ASC);

------


-- ------------ Write CREATE-CONSTRAINT-stage scripts -----------

ALTER TABLE category
ADD CONSTRAINT pk_category_id PRIMARY KEY (id);



ALTER TABLE country
ADD CONSTRAINT pk_country_id PRIMARY KEY (id);



ALTER TABLE customfieldmapping
ADD CONSTRAINT pk_customfieldmapping_id PRIMARY KEY (id);



ALTER TABLE customfieldvalues
ADD CONSTRAINT pk_mappingelement_id PRIMARY KEY (id);



ALTER TABLE diagnosticsviewerrulestate
ADD CONSTRAINT pk_diagnosticsviewerrulestate_id PRIMARY KEY (id);



ALTER TABLE evaluationrequest
ADD CONSTRAINT pk_evaluationrequest_id PRIMARY KEY (id);



ALTER TABLE field
ADD CONSTRAINT pk_field_id PRIMARY KEY (id);



ALTER TABLE fieldtotaxappyear
ADD CONSTRAINT pk_fieldtotaxappyear PRIMARY KEY (fieldid, taxappyearid);



ALTER TABLE fileformat
ADD CONSTRAINT pk_fileformat_id PRIMARY KEY (id);



ALTER TABLE gotolink
ADD CONSTRAINT pk_gotolink_id PRIMARY KEY (id);



ALTER TABLE jurisdiction
ADD CONSTRAINT pk_jurisdiction_id PRIMARY KEY (id);



ALTER TABLE jurisdictiontype
ADD CONSTRAINT pk_jurisdictiontype_id PRIMARY KEY (id);



ALTER TABLE locator
ADD CONSTRAINT pk_locator_id PRIMARY KEY (id);



ALTER TABLE metadatafield
ADD CONSTRAINT pk_metadatafield_s_no PRIMARY KEY (s_no);



ALTER TABLE metadataversion
ADD CONSTRAINT pk_metadataversion_id PRIMARY KEY (id);



ALTER TABLE printdiagnostic
ADD CONSTRAINT pk_printdiagnostic PRIMARY KEY (id);



ALTER TABLE purgerule
ADD CONSTRAINT pk_purgerule_id PRIMARY KEY (id);



ALTER TABLE purgerulegotolink
ADD CONSTRAINT pk_purgerulegotolink_id PRIMARY KEY (id);



ALTER TABLE purgeruletocategory
ADD CONSTRAINT pk_purgeruletocategoryid PRIMARY KEY (purgeruleid, categoryid);



ALTER TABLE purgeruletosecondaryjurisdiction
ADD CONSTRAINT pk_purgeruletojurisdictionid PRIMARY KEY (ruleid, jurisdictionid);



ALTER TABLE purgeruletosecondaryreturntype
ADD CONSTRAINT pk_purgeruletoreturntypeid PRIMARY KEY (ruleid, returntypeid);



ALTER TABLE returntype
ADD CONSTRAINT pk_returntype_id PRIMARY KEY (id);



ALTER TABLE returntypetojurisdiction
ADD CONSTRAINT pk_returntypetojurisdictionid PRIMARY KEY (returntypeid, jurisdictionid);



ALTER TABLE rule
ADD CONSTRAINT pk_rule_id PRIMARY KEY (id);



ALTER TABLE ruleexecutionlog
ADD CONSTRAINT pk_ruleexecutionlog_id PRIMARY KEY (id);



ALTER TABLE ruleexpression
ADD CONSTRAINT pk_ruleexpression_id PRIMARY KEY (id);



ALTER TABLE ruleheader
ADD CONSTRAINT pk_ruleheader_id PRIMARY KEY (id);



ALTER TABLE rulehistory
ADD CONSTRAINT pk_rulehistory_id PRIMARY KEY (id);



ALTER TABLE ruleserviceinstance
ADD CONSTRAINT pk_ruleserviceinstance_id PRIMARY KEY (id);



ALTER TABLE ruletocategory
ADD CONSTRAINT pk_ruletocategoryid PRIMARY KEY (ruleid, categoryid);



ALTER TABLE ruletofield
ADD CONSTRAINT pk_ruletofiid PRIMARY KEY (ruleid, fieldid);



ALTER TABLE ruletosecondaryjurisdiction
ADD CONSTRAINT pk_ruletosecondaryjurisdictionid PRIMARY KEY (ruleid, jurisdictionid);



ALTER TABLE ruletosecondaryreturntype
ADD CONSTRAINT pk_ruletosecondaryreturntypeid PRIMARY KEY (ruleid, returntypeid);



ALTER TABLE schemastructurerulemapping
ADD CONSTRAINT pk_schemastructurerulemapping_id PRIMARY KEY (id);



ALTER TABLE schematype
ADD CONSTRAINT pk_schematype_id PRIMARY KEY (id);



ALTER TABLE serviceconfiguration
ADD CONSTRAINT pk__serviceid PRIMARY KEY (id);



ALTER TABLE taxappyear
ADD CONSTRAINT pk_taxappyear_id PRIMARY KEY (id);



ALTER TABLE taxprofilearea
ADD CONSTRAINT pk_taxprofilearea_id PRIMARY KEY (id);



ALTER TABLE userpreference
ADD CONSTRAINT pk_userpreference_userid PRIMARY KEY (userid);



-- ------------ Write CREATE-FOREIGN-KEY-CONSTRAINT-stage scripts -----------

ALTER TABLE customfieldmapping
ADD CONSTRAINT fk_customfieldmapping_id_jurisdiction FOREIGN KEY (jurisdictionid) 
REFERENCES jurisdiction (id)
ON UPDATE NO ACTION
ON DELETE NO ACTION;



ALTER TABLE customfieldmapping
ADD CONSTRAINT fk_customfieldmapping_id_returntype FOREIGN KEY (returntypeid) 
REFERENCES returntype (id)
ON UPDATE NO ACTION
ON DELETE NO ACTION;



ALTER TABLE customfieldmapping
ADD CONSTRAINT fk_customfieldmapping_id_taxappyear FOREIGN KEY (taxappyearid) 
REFERENCES taxappyear (id)
ON UPDATE NO ACTION
ON DELETE NO ACTION;



ALTER TABLE customfieldvalues
ADD CONSTRAINT fk_customfieldvalues_id_customfieldmapping FOREIGN KEY (customfieldmappingid) 
REFERENCES customfieldmapping (id)
ON UPDATE NO ACTION
ON DELETE NO ACTION;



ALTER TABLE customfieldvalues
ADD CONSTRAINT fk_customfieldvalues_id_rule FOREIGN KEY (ruleid) 
REFERENCES rule (id)
ON UPDATE NO ACTION
ON DELETE CASCADE;



ALTER TABLE diagnosticsviewerrulestate
ADD CONSTRAINT fk_diagnosticsviewerrulestate_locator FOREIGN KEY (locatorid) 
REFERENCES locator (id)
ON UPDATE NO ACTION
ON DELETE CASCADE;



ALTER TABLE diagnosticsviewerrulestate
ADD CONSTRAINT fk_diagnosticsviewerrulestate_rule FOREIGN KEY (ruleid) 
REFERENCES rule (id)
ON UPDATE NO ACTION
ON DELETE CASCADE;



ALTER TABLE field
ADD CONSTRAINT fk_field_id_jurisdiction FOREIGN KEY (jurisdictionid) 
REFERENCES jurisdiction (id)
ON UPDATE NO ACTION
ON DELETE NO ACTION;



ALTER TABLE field
ADD CONSTRAINT fk_field_id_returntype FOREIGN KEY (returntypeid) 
REFERENCES returntype (id)
ON UPDATE NO ACTION
ON DELETE NO ACTION;



ALTER TABLE field
ADD CONSTRAINT fk_field_id_schematype FOREIGN KEY (schematypeid) 
REFERENCES schematype (id)
ON UPDATE NO ACTION
ON DELETE NO ACTION;



ALTER TABLE fieldtotaxappyear
ADD CONSTRAINT fk_fieldtotaxappyear_rule FOREIGN KEY (fieldid) 
REFERENCES field (id)
ON UPDATE NO ACTION
ON DELETE NO ACTION;



ALTER TABLE fieldtotaxappyear
ADD CONSTRAINT fk_fieldtotaxappyear_taxappyear FOREIGN KEY (taxappyearid) 
REFERENCES taxappyear (id)
ON UPDATE NO ACTION
ON DELETE NO ACTION;



ALTER TABLE gotolink
ADD CONSTRAINT fk_ruleid_gotolink FOREIGN KEY (ruleid) 
REFERENCES rule (id)
ON UPDATE NO ACTION
ON DELETE NO ACTION;



ALTER TABLE jurisdiction
ADD CONSTRAINT fk_jurisdiction_id_country FOREIGN KEY (countryid) 
REFERENCES country (id)
ON UPDATE NO ACTION
ON DELETE NO ACTION;



ALTER TABLE jurisdiction
ADD CONSTRAINT fk_jurisdiction_id_jurisdictiontype FOREIGN KEY (jurisdictiontypeid) 
REFERENCES jurisdictiontype (id)
ON UPDATE NO ACTION
ON DELETE NO ACTION;



ALTER TABLE metadataversion
ADD CONSTRAINT fk_metadataversion_id_jurisdiction FOREIGN KEY (jurisdictionid) 
REFERENCES jurisdiction (id)
ON UPDATE NO ACTION
ON DELETE NO ACTION;



ALTER TABLE metadataversion
ADD CONSTRAINT fk_metadataversion_id_returntype FOREIGN KEY (returntypeid) 
REFERENCES returntype (id)
ON UPDATE NO ACTION
ON DELETE NO ACTION;



ALTER TABLE metadataversion
ADD CONSTRAINT fk_metadataversion_id_schematype FOREIGN KEY (schematypeid) 
REFERENCES schematype (id)
ON UPDATE NO ACTION
ON DELETE NO ACTION;



ALTER TABLE metadataversion
ADD CONSTRAINT fk_metadataversion_id_taxappyear FOREIGN KEY (taxappyearid) 
REFERENCES taxappyear (id)
ON UPDATE NO ACTION
ON DELETE NO ACTION;



ALTER TABLE purgerulegotolink
ADD CONSTRAINT fk_ruleid_purgerulegotolink FOREIGN KEY (ruleid) 
REFERENCES purgerule (id)
ON UPDATE NO ACTION
ON DELETE NO ACTION;



ALTER TABLE purgeruletocategory
ADD CONSTRAINT fk_purgeruletocategoryid_category FOREIGN KEY (categoryid) 
REFERENCES category (id)
ON UPDATE NO ACTION
ON DELETE NO ACTION;



ALTER TABLE purgeruletocategory
ADD CONSTRAINT fk_purgeruletocategoryid_rule FOREIGN KEY (purgeruleid) 
REFERENCES purgerule (id)
ON UPDATE NO ACTION
ON DELETE NO ACTION;



ALTER TABLE purgeruletosecondaryjurisdiction
ADD CONSTRAINT fk_purgeruletosecondaryjurisdiction_jurisdiction FOREIGN KEY (jurisdictionid) 
REFERENCES jurisdiction (id)
ON UPDATE NO ACTION
ON DELETE NO ACTION;



ALTER TABLE purgeruletosecondaryjurisdiction
ADD CONSTRAINT fk_purgeruletosecondaryjurisdiction_rule FOREIGN KEY (ruleid) 
REFERENCES purgerule (id)
ON UPDATE NO ACTION
ON DELETE NO ACTION;



ALTER TABLE purgeruletosecondaryreturntype
ADD CONSTRAINT fk_purgeruletosecondaryreturntype_returntype FOREIGN KEY (returntypeid) 
REFERENCES returntype (id)
ON UPDATE NO ACTION
ON DELETE NO ACTION;



ALTER TABLE purgeruletosecondaryreturntype
ADD CONSTRAINT fk_purgeruletosecondaryreturntypeid_rule FOREIGN KEY (ruleid) 
REFERENCES purgerule (id)
ON UPDATE NO ACTION
ON DELETE NO ACTION;



ALTER TABLE returntypetojurisdiction
ADD CONSTRAINT fk_returntypetojurisdictio_jurisdiction FOREIGN KEY (jurisdictionid) 
REFERENCES jurisdiction (id)
ON UPDATE NO ACTION
ON DELETE NO ACTION;



ALTER TABLE returntypetojurisdiction
ADD CONSTRAINT fk_returntypetojurisdiction_returntype FOREIGN KEY (returntypeid) 
REFERENCES returntype (id)
ON UPDATE NO ACTION
ON DELETE NO ACTION;



ALTER TABLE rule
ADD CONSTRAINT fk_rule_id_jurisdiction FOREIGN KEY (jurisdictionid) 
REFERENCES jurisdiction (id)
ON UPDATE NO ACTION
ON DELETE NO ACTION;



ALTER TABLE rule
ADD CONSTRAINT fk_rule_id_returntype FOREIGN KEY (returntypeid) 
REFERENCES returntype (id)
ON UPDATE NO ACTION
ON DELETE NO ACTION;



ALTER TABLE rule
ADD CONSTRAINT fk_rule_id_schematype FOREIGN KEY (schematypeid) 
REFERENCES schematype (id)
ON UPDATE NO ACTION
ON DELETE NO ACTION;



ALTER TABLE rule
ADD CONSTRAINT fk_rule_id_taxappyear FOREIGN KEY (taxappyearid) 
REFERENCES taxappyear (id)
ON UPDATE NO ACTION
ON DELETE NO ACTION;



ALTER TABLE rule
ADD CONSTRAINT fk_rule_id_taxprofilearea FOREIGN KEY (taxprofileareaid) 
REFERENCES taxprofilearea (id)
ON UPDATE NO ACTION
ON DELETE NO ACTION;



ALTER TABLE ruleexecutionlog
ADD CONSTRAINT fk_evaluationrequestid FOREIGN KEY (evaluationrequestid) 
REFERENCES evaluationrequest (id)
ON UPDATE NO ACTION
ON DELETE NO ACTION;



ALTER TABLE ruleexecutionlog
ADD CONSTRAINT fk_ruleexecutionlog_id_locator FOREIGN KEY (locatorid) 
REFERENCES locator (id)
ON UPDATE NO ACTION
ON DELETE NO ACTION;



ALTER TABLE ruleexecutionlog
ADD CONSTRAINT fk_ruleexecutionlog_schematype FOREIGN KEY (schematypeid) 
REFERENCES schematype (id)
ON UPDATE NO ACTION
ON DELETE NO ACTION;



ALTER TABLE ruleexpression
ADD CONSTRAINT fk_ruleexpression_id_jurisdiction FOREIGN KEY (jurisdictionid) 
REFERENCES jurisdiction (id)
ON UPDATE NO ACTION
ON DELETE NO ACTION;



ALTER TABLE ruleexpression
ADD CONSTRAINT fk_ruleexpression_id_returntype FOREIGN KEY (returntypeid) 
REFERENCES returntype (id)
ON UPDATE NO ACTION
ON DELETE NO ACTION;



ALTER TABLE ruleexpression
ADD CONSTRAINT fk_ruleexpression_id_taxappyear FOREIGN KEY (taxappyearid) 
REFERENCES taxappyear (id)
ON UPDATE NO ACTION
ON DELETE NO ACTION;



ALTER TABLE ruleheader
ADD CONSTRAINT fk_ruleheader_id_fileformat FOREIGN KEY (fileformatid) 
REFERENCES fileformat (id)
ON UPDATE NO ACTION
ON DELETE NO ACTION;



ALTER TABLE ruleheader
ADD CONSTRAINT fk_ruleheader_id_jurisdiction FOREIGN KEY (jurisdictionid) 
REFERENCES jurisdiction (id)
ON UPDATE NO ACTION
ON DELETE NO ACTION;



ALTER TABLE ruleheader
ADD CONSTRAINT fk_ruleheader_id_returntype FOREIGN KEY (returntypeid) 
REFERENCES returntype (id)
ON UPDATE NO ACTION
ON DELETE NO ACTION;



ALTER TABLE ruleheader
ADD CONSTRAINT fk_ruleheader_id_taxappyear FOREIGN KEY (taxappyearid) 
REFERENCES taxappyear (id)
ON UPDATE NO ACTION
ON DELETE NO ACTION;



ALTER TABLE rulehistory
ADD CONSTRAINT fk_rulehistory_rule_id FOREIGN KEY (ruleid) 
REFERENCES rule (id)
ON UPDATE NO ACTION
ON DELETE NO ACTION;



ALTER TABLE ruletocategory
ADD CONSTRAINT fk_ruletocategoryid_category FOREIGN KEY (categoryid) 
REFERENCES category (id)
ON UPDATE NO ACTION
ON DELETE NO ACTION;



ALTER TABLE ruletocategory
ADD CONSTRAINT fk_ruletocategoryid_rule FOREIGN KEY (ruleid) 
REFERENCES rule (id)
ON UPDATE NO ACTION
ON DELETE NO ACTION;



ALTER TABLE ruletofield
ADD CONSTRAINT fk_ruletofieldid_field FOREIGN KEY (fieldid) 
REFERENCES field (id)
ON UPDATE NO ACTION
ON DELETE NO ACTION;



ALTER TABLE ruletofield
ADD CONSTRAINT fk_ruletofieldid_rule FOREIGN KEY (ruleid) 
REFERENCES rule (id)
ON UPDATE NO ACTION
ON DELETE NO ACTION;



ALTER TABLE ruletosecondaryjurisdiction
ADD CONSTRAINT fk_ruletosecondaryjurisdiction_jurisdiction FOREIGN KEY (jurisdictionid) 
REFERENCES jurisdiction (id)
ON UPDATE NO ACTION
ON DELETE NO ACTION;



ALTER TABLE ruletosecondaryjurisdiction
ADD CONSTRAINT fk_ruletosecondaryjurisdiction_rule FOREIGN KEY (ruleid) 
REFERENCES rule (id)
ON UPDATE NO ACTION
ON DELETE NO ACTION;



ALTER TABLE ruletosecondaryreturntype
ADD CONSTRAINT fk_ruletosecondaryreturntype_returntype FOREIGN KEY (returntypeid) 
REFERENCES returntype (id)
ON UPDATE NO ACTION
ON DELETE NO ACTION;



ALTER TABLE ruletosecondaryreturntype
ADD CONSTRAINT fk_ruletosecondaryreturntypeid_rule FOREIGN KEY (ruleid) 
REFERENCES rule (id)
ON UPDATE NO ACTION
ON DELETE NO ACTION;

/*

NOTICE:  identifier "ix_evaluationrequest_ncidx_evaluation_requeststatus_instancename" will be truncated to "ix_evaluationrequest_ncidx_evaluation_requeststatus_instancenam"
NOTICE:  identifier "ix_locator_ncidx_locator_returntype_taxappyear_jurisdiction_name" will be truncated to "ix_locator_ncidx_locator_returntype_taxappyear_jurisdiction_nam"
NOTICE:  identifier "ix_rule_ncidx_rule_returntypeid_taxappyearid_jurisdictionid_schematypeid" will be truncated to "ix_rule_ncidx_rule_returntypeid_taxappyearid_jurisdictionid_sch"
*/
