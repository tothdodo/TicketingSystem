class Auditorium{
    id!: number;
    sectors: Sector[] = [];
}

class Sector{
    id!: number;
    sectorName!: string;
    rows: Row[] = [];

    auditoriumId!: number; //FK
    auditorium!: Auditorium;
}

class Row{
    id!: number;
    rowNumber!: number;
    seats: Seat[] = [];

    sectorId!: number; //FK
    sector!: Sector;
}

class Seat{
    id!: number;
    seatNumber!: number;
    
    rowId!: number; //FK
    row!: Row;

    gameSeats: GameSeat[] = [];
}

class GameSeat{
    id!: number;
    status!: string;

    seatId!: number; //FK
    seat!: Seat;
    gameId!: number; //FK
    game!: Game;
}

class Game{
    id!: number;
    gameSeats: GameSeat[] = [];
}