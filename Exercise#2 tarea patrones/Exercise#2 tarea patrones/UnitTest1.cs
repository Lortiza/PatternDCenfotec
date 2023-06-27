namespace Exercise_2_tarea_patrones
{
    
    

    
    public class IMCTests
    {
        [Fact]
        public void Calcular_NormalWeightMI()
        {
            // Arrange
            var imc = new IMC();
            imc.Peso = 70;
            imc.Estatura = 1.75;

            // Act
            imc.Calcular();

            // Assert
            Assert.Equal(22.86, imc.Resultado, 2);
            Assert.Equal(NivelIMC.Normal, imc.Nivel);
        }


        [Fact]
        public void Calcular_Underweight_ReturnsUnderweightBMI()
        {
            // Arrange
            var imc = new IMC();
            imc.Peso = 50;
            imc.Estatura = 1.75;

            // Act
            imc.Calcular();

            // Assert
            Assert.True(imc.Resultado < 18.5);
            Assert.Equal(NivelIMC.BajoPeso, imc.Nivel);
        }


        [Fact]
        public void Calcular_Overweight_ReturnsOverweightBMI()
        {
            // Arrange
            var imc = new IMC();
            imc.Peso = 85;
            imc.Estatura = 1.75;

            // Act
            imc.Calcular();

            // Assert
            Assert.InRange(imc.Resultado, 25, 29.9);
            Assert.Equal(NivelIMC.Sobrepeso, imc.Nivel);
        }

        [Fact]
        public void Calcular_Obesity_ReturnsObeseBMI()
        {
            // Arrange
            var imc = new IMC();
            imc.Peso = 100;
            imc.Estatura = 1.75;

            // Act
            imc.Calcular();

            // Assert
            Assert.True(imc.Resultado > 30);
            Assert.Equal(NivelIMC.Obeso, imc.Nivel);
        }

        [Fact]
        public void NivelDescripcion_ReturnsCorrectDescription()
        {
            // Arrange
            var imc = new IMC();
            imc.Peso = 100;
            imc.Estatura = 1.75;

            // Act
            imc.Calcular();
            var descripcion = imc.NivelDescripcion();

            // Assert
            Assert.Equal("Obesidad. Más de 30.0", descripcion);
        }




    }
}



