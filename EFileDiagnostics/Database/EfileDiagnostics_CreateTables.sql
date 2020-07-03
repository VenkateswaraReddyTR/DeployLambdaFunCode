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

