using Domain;
using FluentAssertions;

namespace FlightTest
{
    public class FlightSpecifications
    {
        [Theory]
        [InlineData(3,1,2)]
        [InlineData(6,3,3)]
        [InlineData(10,6,4)]
        [InlineData(12,8,4)]
        public void Booking_reduces_the_number_of_seats(int seatCapacity, int numberOfSeats, int remainingNumberOfSeats)
        {
            var flight = new Flight(seatCapacity: seatCapacity);

            flight.Book("luca.daprano@outlook.com", numberOfSeats);

            flight.RemainingNumberOfSeats.Should().Be(remainingNumberOfSeats);
        }

        [Fact]
        public void Avoids_overbooking()
        {
            // Given
            var flight = new Flight(seatCapacity: 3);
            // When
            var error = flight.Book("luca.daprano@outlook.com", 4);
            // Then
            error.Should().BeOfType<OverbookingError>();
        }

        [Fact]
        public void Books_flights_successfully()
        {
            var flight = new Flight(seatCapacity: 3);
            var error = flight.Book("luca.daprano@outlook.com", 1);
            error.Should().BeNull();
        }

        [Fact]

        public void Remembers_bookings()
        {
            var flight = new Flight(seatCapacity: 150);

            flight.Book(passengerEmail: "a@b.com", numberOfSeats: 4);

            flight.BookingList.Should().ContainEquivalentOf(new Booking("a@b.com", 4));
        }

        [Theory]
        [InlineData(3,1,1,3)]
        [InlineData(4,2,2,4)]
        [InlineData(7,5,4,6)]
        public void Cancelling_bookings_frees_up_seats(int initialCapacity, int numberOfSeatsToBook, int numberOfSeatsToCancel, int remainingNumberOfSeats)
        {
            // Given
            var flight = new Flight(initialCapacity);
            flight.Book(passengerEmail: "a@b.com", numberOfSeats: numberOfSeatsToBook);

            // When
            flight.CancelBooking(passengerEmail: "a@b.com", numberOfSeats: numberOfSeatsToCancel, flightId: flight.Id);

            // Then
            flight.RemainingNumberOfSeats.Should().Be(remainingNumberOfSeats);
        }

        [Fact]
        public void Doesnt_cancel_bookings_for_passengers_who_have_not_booked()
        {
            // Given
            var flight = new Flight(3);
            var error = flight.CancelBooking(passengerEmail: "a@b.com", numberOfSeats: 2, flightId: flight.Id);
            error.Should().BeOfType<BookingNotFoundError>();
        }

        [Fact]
        public void Returns_null_when_cancel_booking_is_successful()
        {
            var flight = new Flight(3);
            flight.Book(passengerEmail: "a@b.com", numberOfSeats: 1);
            var error = flight.CancelBooking(passengerEmail: "a@b.com", numberOfSeats: 1, flightId: flight.Id);
            error.Should().BeNull();
        }
    }
}