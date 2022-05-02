using Composition;

var logger = new Logger();
var installer = new Installer(logger);
var migrator = new DbMigrator(new Logger());

installer.install();
migrator.Migrate();