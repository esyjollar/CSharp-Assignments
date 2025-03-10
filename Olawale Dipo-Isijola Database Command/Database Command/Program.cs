using System;

public abstract class DbConnection
{
    private string _connectionString;
    private TimeSpan _timeout;

    // Constructor to initialize the connection string and set a default timeout
    protected DbConnection(string connectionString)
    {
        if (string.IsNullOrWhiteSpace(connectionString))
            throw new ArgumentException("Connection string cannot be null or empty.");

        _connectionString = connectionString;
        _timeout = TimeSpan.FromSeconds(30); // Default timeout
    }

    // Property to get the connection string
    public string ConnectionString
    {
        get { return _connectionString; }
    }

    // Property to get and set the timeout value
    public TimeSpan Timeout
    {
        get { return _timeout; }
        set { _timeout = value; }
    }

    // Abstract methods to be implemented by derived classes
    public abstract void Open();
    public abstract void Close();
}

public class SqlConnection : DbConnection
{
    // Constructor to initialize the connection string for SQL connection
    public SqlConnection(string connectionString) : base(connectionString) { }

    // Implementation of the Open method for SQL connection
    public override void Open()
    {
        Console.WriteLine("SQL Connection Opened.");
    }

    // Implementation of the Close method for SQL connection
    public override void Close()
    {
        Console.WriteLine("SQL Connection Closed.");
    }
}

public class OracleConnection : DbConnection
{
    // Constructor to initialize the connection string for Oracle connection
    public OracleConnection(string connectionString) : base(connectionString) { }

    // Implementation of the Open method for Oracle connection
    public override void Open()
    {
        Console.WriteLine("Oracle Connection Opened.");
    }

    // Implementation of the Close method for Oracle connection
    public override void Close()
    {
        Console.WriteLine("Oracle Connection Closed.");
    }
}

public class DbCommand
{
    private DbConnection _dbConnection;
    private string _instruction;

    // Constructor to initialize the DbCommand with a connection and an instruction
    public DbCommand(DbConnection dbConnection, string instruction)
    {
        if (dbConnection == null)
            throw new ArgumentNullException(nameof(dbConnection), "DbConnection cannot be null.");

        if (string.IsNullOrWhiteSpace(instruction))
            throw new ArgumentException("Instruction cannot be null or empty.");

        _dbConnection = dbConnection;
        _instruction = instruction;
    }

    // Method to execute the command: open connection, run instruction, close connection
    public void Execute()
    {
        _dbConnection.Open();
        Console.WriteLine($"Executing instruction: {_instruction}");
        _dbConnection.Close();
    }
}

class Program
{
    static void Main()
    {
        // Initialize DbCommand with SqlConnection and execute
        DbConnection sqlConnection = new SqlConnection("SQL_Connection_String");
        DbCommand sqlCommand = new DbCommand(sqlConnection, "SELECT * FROM Users");
        sqlCommand.Execute();

        // Initialize DbCommand with OracleConnection and execute
        DbConnection oracleConnection = new OracleConnection("Oracle_Connection_String");
        DbCommand oracleCommand = new DbCommand(oracleConnection, "SELECT * FROM Employees");
        oracleCommand.Execute();
    }
}