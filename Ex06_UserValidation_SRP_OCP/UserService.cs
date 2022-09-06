using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex06_UserValidation_SRP_OCP
{
    public class UserService
    {
        private readonly IUserRepository _userRepository;

        private readonly List<IValidator> _validators;

        public UserService(List<IValidator> validators, IUserRepository userRepository)
        {
            this._validators = validators;
            this._userRepository = userRepository;
        }

        public bool CreateUser(User user)
        {
            // Validate the user
            foreach (var validator in _validators)
            {
                if(!validator.Validate(user))
                    return false;
            }

            // Save the user (repository)
            _userRepository.Save(user);

            return true;
        }

    }
}
